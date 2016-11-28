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

namespace WindowsProgramingHomework8.Dialogs {
    public partial class TextOptionsDialog : Form {
        TextsDocument document;
        private double fontSize;
        public TextOptionsDialog(TextsDocument doc) {
            InitializeComponent();
            document = doc;

            this.textsDocumentBindingSource.DataSource = document;
            int pos = BindingManager.Position;
            if (pos != -1) {
                Text txt = this.textsComboBox.Items[BindingManager.Position] as Text;
                fontSize = txt.Font.Size;
            }
            textsComboBox.SelectedIndex = this.BindingManager.Position;
            RefreshItems();
        }

        private void buttonChangeFont_Click(object sender, EventArgs e) {
            using (FontDialog dlg = new FontDialog()) {
                if (dlg.ShowDialog() == DialogResult.OK) {
                    this.fontTextBox.Text = dlg.Font.Name;
                    this.fontTextBox.Font = new Font(dlg.Font.Name, (float)8.0, dlg.Font.Style);
                    fontSize = dlg.Font.Size;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            ++this.BindingManager.Position;
            textsComboBox.SelectedIndex = this.BindingManager.Position;
            RefreshItems();
        }

        private void buttonPrevious_Click(object sender, EventArgs e) {
            --this.BindingManager.Position;
            textsComboBox.SelectedIndex = this.BindingManager.Position;
            RefreshItems();
        }
        void RefreshItems() {
            int count = (this.BindingManager.Count == -1) ? 0 : this.BindingManager.Count;
            int pos = this.BindingManager.Position;
            this.buttonPrevious.Enabled = (pos > 0);
            this.buttonNext.Enabled = (pos < count - 1);            

            //this is necessary to avoid a bug with the font being changed accidentally
            if (BindingManager.Position != -1) {
                this.fontTextBox.Font = new Font(document.Texts[BindingManager.Position].Font.Name, 8.0F,
    document.Texts[BindingManager.Position].Font.Style);
                fontSize = document.Texts[BindingManager.Position].Font.Size;
                this.fontTextBox.Text = document.Texts[BindingManager.Position].Font.Name + $", {fontSize}";
            }
        }
        public void ChangeSelected(Text newSelection) {
            int pos = 0;
            for (int i = 0; i < document.Texts.Count; i++) {
                if (newSelection == document.Texts[i]) {
                    pos = i;
                }
            }
            BindingManager.Position = pos;
            textsComboBox.SelectedIndex = this.BindingManager.Position;
            RefreshItems();
        }

        private void textsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            
            if (BindingManager.Position != textsComboBox.SelectedIndex)
            {
                int lastI = BindingManager.Position;
                int newI = textsComboBox.SelectedIndex;

                onTextsIndexChange(lastI, newI);                
            }

            BindingManager.Position = textsComboBox.SelectedIndex;
            RefreshItems();
            //this.Owner.Refresh();

        }
        BindingManagerBase BindingManager {
            get { return this.BindingContext[this.document.Texts]; }
        }

        private void buttonApply_Click(object sender, EventArgs e) {
            try {
                onClickEqualOKorApply();
            } catch (Exception ex) { }
            this.Owner.Refresh();
        }
        private void buttonOk_Click(object sender, EventArgs e) {
            try {
                onClickEqualOKorApply();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            this.Owner.Refresh();
            this.Close();
        }

        //apply and OK buttons have this code the same:
        public void onClickEqualOKorApply() {
            float x = 0;
            string input = new String(locationTextBox.Text.Split(',')[0].Where(Char.IsDigit).ToArray());
            float.TryParse(input, out x);

            float y = 0;
            input = new String(locationTextBox.Text.Split(',')[1].Where(Char.IsDigit).ToArray());
            float.TryParse(input, out y);

            double rot;
            double.TryParse(rotationTextBox.Text, out rot);

            int zOrder;
            int.TryParse(zOrderTextBox.Text, out zOrder);

            document.Texts.ElementAt(textsComboBox.SelectedIndex).Font = new Font(fontTextBox.Font.Name,
                (float)fontSize, fontTextBox.Font.Style);
            document.Texts.ElementAt(textsComboBox.SelectedIndex).Location = new PointF(x, y);
            document.Texts.ElementAt(textsComboBox.SelectedIndex).Rotation = rot;
            document.Texts.ElementAt(textsComboBox.SelectedIndex).TextToDraw = textToDrawTextBox.Text;
            document.Texts.ElementAt(textsComboBox.SelectedIndex).ZOrder = zOrder;
        }
        public void onTextsIndexChange(int lastI, int newI)
        {
            
            if (document.Texts.ElementAt(lastI).Highlighted == true)
            {
                document.Texts.ElementAt(lastI).Highlighted = false;
            }
            if (newI > -1)
            {
                document.Texts.ElementAt(newI).Highlighted = true;
            }
            this.Owner.Refresh();
        }

        private void bringToFrontButton_Click(object sender, EventArgs e) {
            Text currentFront = document.Texts.FirstOrDefault((text) => text.ZOrder == 0);
            if (currentFront != null) {//if someone had a zorder of 1, move them all back by 1
                foreach (var text in document.Texts) {
                    text.ZOrder++;
                }
            }
            document.Texts[textsComboBox.SelectedIndex].ZOrder = 0;
            this.Owner.Refresh();
        }

        private void sendToBackButton_Click(object sender, EventArgs e) {
            document.Texts[textsComboBox.SelectedIndex].ZOrder = document.NextZOrder();
            this.Owner.Refresh();
        }
    }
}
