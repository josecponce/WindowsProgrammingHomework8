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
    public partial class OathDialog : DialogBase
    {
        public OathUserControl OathControl { get; set; }
        int width;
        int height;
        Rectangle rectGradient;
        BufferedGraphicsContext bufferContext;
        Point ptCenter = Point.Empty;



        public OathDialog()
        {
            InitializeComponent();
            OathControl = new OathUserControl();
            OathControl.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(OathControl);
            bufferContext = new BufferedGraphicsContext();
            bufferContext.MaximumBuffer = this.ClientRectangle.Size;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }
        private void OathDialog_Load(object sender, EventArgs e)
        {
            width = this.ClientRectangle.Width;
            height = this.ClientRectangle.Height;
            rectGradient = new Rectangle(0, height*4, width, height);
            bufferContext.MaximumBuffer = rectGradient.Size;
        }
        private void OathDialog_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 0;
            int y = 0;
         
            Point[] points = new Point[] { new Point(x, y),
                                     new Point(width, y),
                                     new Point(width, height),
                                     new Point(x, height) };
            using (PathGradientBrush brush = new PathGradientBrush(points))
            {
                brush.CenterColor = Color.DarkSalmon;
                brush.CenterPoint = ptCenter;
                brush.FocusScales = new PointF(0.05f, 0.05f);

                g.FillRectangle(brush, x, y, width, height);

            }
        }

    }
}
