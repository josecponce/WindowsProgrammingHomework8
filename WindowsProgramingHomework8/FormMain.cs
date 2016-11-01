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
            base.Initialize(fileName);
            
            //setting handlers from parent class because designer won't do it for some unamusing reason
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            this.Paint += new System.Windows.Forms.PaintEventHandler(TopLevelForm_Paint); 

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


        //THIS IS TESTING , NEEDS TO BE MOVED TO CORRECT LOCATION
        /*will DrawString on the form the words from the file*/
        protected void TopLevelForm_Paint(object sender, PaintEventArgs e)
        {
            //text that will be displayed:
           string toDraw = "test draw";
           //color:
            Brush brush = new SolidBrush(Color.Blue);
            //size:
            float size = 12F;
            //location:
            int x = 0;
            int y = 40;

           int numberOfItems = document.Texts.Count;

            if(numberOfItems != 0) { 
            TextsDocument document2 = document;
            toDraw = document.Texts.ElementAt(0).TextToDraw;
           }
           
            Graphics g = e.Graphics;

            Font font = new Font("Arial", size);
            FontFamily family = font.FontFamily;

            
            //g.DrawLine(Pens.Black, 0, y, width, y);
            g.DrawString(toDraw, font, brush, x, y);

        }



    }
}
