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

        
        /*will DrawString on the form the words from the file*/
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            int numberOfItems = document.Texts.Count;

            float y = 30;
           
            for (int i = 0; i < numberOfItems; i++)
            {

                //location:
                float x = document.Texts.ElementAt(i).Location.X;
                //float y = document.Texts.ElementAt(i).Location.Y + 30;

                //size:
                float size = document.Texts.ElementAt(i).Font.Size;
                //Font:
                var font = document.Texts.ElementAt(i).Font;

                //text that will be displayed:
                string toDraw = "test draw";
                //color:
                Brush brush = new SolidBrush(Color.Black);

              
                toDraw = document.Texts.ElementAt(i).TextToDraw;
                               
                //g.RotateTransform(30);

                //NEED TO FIX: DEPENDING ON SIZE DRAW
                g.DrawString(toDraw, font, brush, x, y);
                                            

                y += 20;
                
            }//end forloop

        }

        //prompt to enter a word to draw
        private void FormMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a Word to draw",
                        "Enter a Word to draw",
                        "Default",
                        0,
                        0);

            Graphics f = this.CreateGraphics();
            f.DrawString(input, new Font("Arial", 16), new SolidBrush(Color.Black) , e.X, e.Y);

            Text t = new Text(input ,new PointF(e.X , e.Y), new Font("Arial", 16) , 0);

            document.Texts.Add(t);

            //this.Refresh();
        }
    }
}
