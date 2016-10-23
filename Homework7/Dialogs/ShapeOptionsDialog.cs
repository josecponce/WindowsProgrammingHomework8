using Homework7.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7.Dialogs
{
    public partial class ShapeOptionsDialog : Form
    {
        ShapesDocument document;
        public ShapeOptionsDialog(ShapesDocument doc)
        {
            InitializeComponent();
            document = doc;
            this.shapesDocumentBindingSource.DataSource = document;
            RefreshItems();

        }
        BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.document.Shapes]; }
        }
        void RefreshItems()
        {
            int count = this.BindingManager.Count;
            int pos = this.BindingManager.Position + 1;
            this.buttonPrevious.Enabled = (pos > 1);
            this.buttonNext.Enabled = (pos < count);
            shapesComboBox.SelectedIndex = pos-1;
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

        private void buttonChangePenColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    //will modify the element of shape at selected index
                    document.Shapes.ElementAt(shapesComboBox.SelectedIndex).PenColor = dlg.Color;
                    
                }
            }
        }

        private void buttonChangeBrushColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                    //will modify the element of shape at selected index
                    document.Shapes.ElementAt(shapesComboBox.SelectedIndex).BrushColor = dlg.Color;
                   
                }
            }
        }

        private void radioButtonEllipse_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if(r.Checked == true)
            {
                typeTextBox.Text = r.Text;
            }
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                typeTextBox.Text = r.Text;
            }
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                typeTextBox.Text = r.Text;
            }
        }

        private void radioButtonPenSolid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                penTypeTextBox.Text = r.Text;
            }
        }

        private void radioButtonPenDashed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                penTypeTextBox.Text = r.Text;
            }
        }

        private void radioButtonPenCompound_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                penTypeTextBox.Text = r.Text;
            }
        }

        private void radioButtonBrushSolid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                brushTypeTextBox.Text = r.Text;
            }
        }

        private void radioButtonBrushLinearGradient_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                brushTypeTextBox.Text = r.Text;
            }
        }

        private void radioButtonBrushHatshed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if (r.Checked == true)
            {
                brushTypeTextBox.Text = r.Text;
            }
        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBoxShapeType.Controls)
            {
                if (r.Text == typeTextBox.Text)
                {
                    r.Checked = true;
                    return;
                }
            }

        }

        private void penTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBoxPen.Controls)
            {
                if (r.Text == penTypeTextBox.Text)
                {
                    r.Checked = true;
                    return;
                }
            }
        }

        private void brushTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBoxBrush.Controls)
            {
                if (r.Text == brushTypeTextBox.Text)
                {
                    r.Checked = true;
                    return;
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            try {
                //helper variables
                String penType = penTypeTextBox.Text;
                String brushtype = brushTypeTextBox.Text;

                //change shape type:
                document.Shapes.ElementAt(shapesComboBox.SelectedIndex).Type = (ShapeType)Enum.Parse(typeof(ShapeType), typeTextBox.Text);
               
                //change pen type:
                document.Shapes.ElementAt(shapesComboBox.SelectedIndex).PenType = (PenType)Enum.Parse(typeof(PenType), penType);

                //brush:
                document.Shapes.ElementAt(shapesComboBox.SelectedIndex).BrushType = (BrushType)Enum.Parse(typeof(BrushType), brushtype);

            }
            catch (Exception ex) {
                //no shape was selected
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void shapesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingManager.Position = shapesComboBox.SelectedIndex;
            RefreshItems();
            
        }
    }
}
