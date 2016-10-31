using Homework3ControlLib;
using Homework7;
using Microsoft.Practices.Unity;
using SingleInstanceApplicationLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProgramingHomework8.Dialogs;
using WindowsProgramingHomework8.Entities;

namespace WindowsProgramingHomework8 {
    public partial class FormMain : TopLevelForm<TextsDocument> {

        public override ToolStripMenuItem WindowsMenu =>
            windowsToolStripMenuItem;
        protected override bool unsavedChanges => document.Dirty;

        public FormMain(IUnityContainer container, IDocumentRepository<TextsDocument> repository) 
            : base(container, repository) {
            InitializeComponent();
        }
        protected override void Initialize(string fileName) {
            string extension = fileName.Substring(
                fileName.LastIndexOf("."),
                fileName.Length - fileName.LastIndexOf("."));
            //if it's a new Doc or it has "our" binary extension, this is enough
            if (fileName == null || extension == ".wtxt") {
                base.Initialize(fileName);
            }else {
                //we need to create a way to deserialize other file types                
            }
            
            //setting handlers from parent class because designer won't do it for some unamusing reason
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        }

        protected override void saveFile(bool promptUser) {
            base.saveFile(promptUser);
            document.Dirty = false;        
        }

        private void textOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bringToFrontIfExists<TextOptionsDialog>()) {
                return;
            }
            TextOptionsDialog pForm = new TextOptionsDialog(this.document);
            pForm.Show(this);
        }


        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bringToFrontIfExists<SearchDialog>()) {
                return;
            }
            SearchDialog searchDialog = new SearchDialog();
            searchDialog.Show(this);
        }

        private bool bringToFrontIfExists<Q>() where Q : Form{
            foreach (Form f in Application.OpenForms) {
                if (f is Q) {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    f.BringToFront();
                    f.Focus();
                    return true;
                }
            }
            return false;
        }
    }
}
