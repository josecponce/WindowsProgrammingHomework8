using Homework3ControlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7.Dialogs
{
    public partial class AboutDialog : DialogBase
    {
        public AboutDialog()
        {
            InitializeComponent();
            ContentPanel.Controls.Add(createDecriptionLabel(Description));
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private Label createDecriptionLabel(string description)
        {
            var label = new Label();
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.Text = description;
            return label;
        }

        private const string Description = "This application draws texts instead of \r\n" +
                                        "using text box controls. It uses a thread to find \r\n " +
                                        "text elements in the file system. It uses data binding \r\n" +
                                        "to exchange data between the main form and the text \r\n" +
                                        "options dialog.";

        private void AboutDialog_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = this.ClientRectangle.Width;
            int height = this.ClientRectangle.Height;

            using (
              LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.White,
                Color.Black,
                LinearGradientMode.ForwardDiagonal))
            {

                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Color.White, Color.Salmon, Color.LightBlue,  Color.Black, };
                blend.Positions = new float[] { 0.0f, 0.25f, 0.75f, 1.0f };
                brush.InterpolationColors = blend;

                Pen pen = new Pen(brush);
                pen.Width = 20;
                g.DrawRectangle(pen, new Rectangle(10, 10, this.ClientRectangle.Width-20, this.ClientRectangle.Height-20));


            }

        }

    }
}

