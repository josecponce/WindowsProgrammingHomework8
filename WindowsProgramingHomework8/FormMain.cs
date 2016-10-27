using Homework3ControlLib;
using Homework7;
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
    public partial class FormMain:Form
    {
        private TextsDocument document;
        public FormMain(string fileName = null)
        {
            InitializeComponent();
            if (fileName == null)
            {
                document = new TextsDocument();
            }

        }

        private void textOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is TextOptionsDialog)
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    f.BringToFront();
                    f.Focus();
                    return;
                }
            }

            TextOptionsDialog pForm = new TextOptionsDialog(this.document);
            pForm.Show(this);
        }


        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
