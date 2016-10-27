using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProgramingHomework8.Entities;

namespace WindowsProgramingHomework8.Dialogs
{
      public partial class TextOptionsDialog : Form
    {
        TextsDocument document;
        private double fontSize;
        public TextOptionsDialog(TextsDocument doc)
        {
            InitializeComponent();
            document = doc;
            this.textsDocumentBindingSource.DataSource = document;
            RefreshItems();
        }

        private void buttonChangeFont_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.fontTextBox.Text = dlg.Font.Name;
                    this.fontTextBox.Font = new Font(dlg.Font.Name, (float)8.0, dlg.Font.Style);
                    fontSize = dlg.Font.Size;
                }
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                float x = 0;
                float.TryParse(locationTextBox.Text.Split(',')[0], out x);
                float y = 0;
                float.TryParse(locationTextBox.Text.Split(',')[1], out y);
                double rot;
                double.TryParse(rotationTextBox.Text, out rot);

                document.Texts.ElementAt(textsComboBox.SelectedIndex).Font = new Font(fontTextBox.Font.Name, (float)fontSize, fontTextBox.Font.Style);

                //Need fix
                document.Texts.ElementAt(textsComboBox.SelectedIndex).Location = new PointF(x, y);

                document.Texts.ElementAt(textsComboBox.SelectedIndex).Rotation = rot;

                document.Texts.ElementAt(textsComboBox.SelectedIndex).TextToDraw = textToDrawTextBox.Text;


            }
            catch (Exception ex)
            {

            }


            this.Owner.Refresh();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++this.BindingManager.Position;
            RefreshItems();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            --this.BindingManager.Position;
            RefreshItems();
        }
        void RefreshItems()
        {
            int count = this.BindingManager.Count;
            int pos = this.BindingManager.Position + 1;
            this.buttonPrevious.Enabled = (pos > 1);
            this.buttonNext.Enabled = (pos < count);
            textsComboBox.SelectedIndex = pos - 1;
        }

        private void textsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingManager.Position = textsComboBox.SelectedIndex;
            RefreshItems();
        }
        BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.document.Texts]; }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {

            try
            {
                float x = 0;
                float.TryParse(locationTextBox.Text.Split(',')[0], out x);
                float y = 0;
                float.TryParse(locationTextBox.Text.Split(',')[1], out y);
                double rot;
                double.TryParse(rotationTextBox.Text,out rot);


                document.Texts.ElementAt(textsComboBox.SelectedIndex).Font = new Font(fontTextBox.Font.Name, (float)fontSize, fontTextBox.Font.Style);

                //Need fix
                document.Texts.ElementAt(textsComboBox.SelectedIndex).Location = new PointF(x,y);

                document.Texts.ElementAt(textsComboBox.SelectedIndex).Rotation = rot;

                document.Texts.ElementAt(textsComboBox.SelectedIndex).TextToDraw = textToDrawTextBox.Text;


            }
            catch (Exception ex)
            {
                
            }

            this.Owner.Refresh();

        }
    }
}
