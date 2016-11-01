using Microsoft.Practices.Unity;
using System;
using System.Windows.Forms;

namespace SingleInstanceApplicationLib
{
    public class TopLevelForm<T> : Form where T : new() {
        private IUnityContainer container;
        private IDocumentRepository<T> repository;

        protected T document;
        protected static int formCount = 0;       
                
        public virtual ToolStripMenuItem WindowsMenu { get; }
        protected virtual bool unsavedChanges { get; }
        protected virtual string fileFilter =>
            "Weird Text Files(*.wtxt)|*.wtxt|All files|*.*";

        protected string fileName;

        public TopLevelForm() { }
        public TopLevelForm(IUnityContainer container, IDocumentRepository<T> repository) {
            formCount++;
            this.container = container;
            this.repository = repository;

            this.FormClosing += TopLevelForm_FormClosing;            
        }

        public static TopLevelForm<T> CreateTopLevelWindow(string fileName, IUnityContainer container){
            if (!string.IsNullOrEmpty(fileName)) {
                foreach (Form openForm in Application.OpenForms) {
                    if (!(openForm is TopLevelForm<T>))
                        continue;
                    TopLevelForm<T> f = openForm as TopLevelForm<T>;
                    if (string.Compare(f.fileName, fileName,
                        true) == 0) {
                        openForm.Activate();
                        return f;
                    }
                }
            }
            TopLevelForm<T> form = container.Resolve<TopLevelForm<T>>();            
            form.Initialize(fileName);
            container.Resolve<SingleInstanceApplication<T>>()
                .AddTopLevelForm(form);
            form.Activate();
            form.Show();
            return form;
        }
        protected virtual void Initialize(string fileName) {
            if (fileName == null) {
                document = new T();
                this.fileName = "untitled:" + formCount;
            } else {
                document = repository.LoadDocument(fileName);
                this.fileName = fileName;
            }
            this.Text = this.fileName;
        }

        protected void TopLevelForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (unsavedChanges) {
                promptSaveBeforeChangesLost();
            } else {
                DialogResult result = MessageBox.Show("Are you sure you want to quit?",
                    "Exit Now?", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }
        }
        protected void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFile(fileName.StartsWith("untitled:"));
        }
        protected void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFile(true);
        }
        protected void newToolStripMenuItem_Click(object sender, EventArgs e) {
            CreateTopLevelWindow(null, container);
        }
        protected void openToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Filter = fileFilter;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK) {
                    CreateTopLevelWindow(dialog.FileName, container);
                    //opens new file, initializes document: 
                    Initialize(dialog.FileName);
                }
            }
        }
        protected void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void promptSaveBeforeChangesLost() {
            DialogResult result = MessageBox.Show("Do you want to save before continuing", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                saveToolStripMenuItem_Click(null, null);
            }
        }        
        protected virtual void saveFile(bool promptUser) {
            if (promptUser) {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.Filter = fileFilter;
                    DialogResult result = saveFileDialog.ShowDialog();
                    if (result != DialogResult.OK)
                        return;
                    fileName = saveFileDialog.FileName;
                }
            }
            repository.SaveDocument(document, fileName);
            this.Text = fileName;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TopLevelForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "TopLevelForm";
            this.ResumeLayout(false);            

        }

       
      


    }
}
