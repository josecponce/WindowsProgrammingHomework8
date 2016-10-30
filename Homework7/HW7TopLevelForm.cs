using Homework3ControlLib;
using Homework7.Dialogs;
using Homework7.Entities;
using Microsoft.Practices.Unity;
using SingleInstanceApplicationLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7 {
    public partial class HW7TopLevelForm : TopLevelForm<ShapesDocument> {
        private Dialogs.AboutDialog aboutDialog;
        private Dialogs.OathDialog oathDialog;

        //this template should be "cloned" not used as is
        private Shape template = new Shape {
            Location = Point.Empty,
            Size = Size.Empty,
            BrushColor = Color.AliceBlue,
            BrushType = BrushType.Solid,
            PenColor = Color.Black,
            PenType = PenType.Solid,
            Type = ShapeType.Ellipse
        };
        private Shape drawingShape = null;

        public override ToolStripMenuItem WindowsMenu =>
            windowsToolStripMenuItem;
        protected override void Initialize(string fileName) {
            base.Initialize(fileName);
            document.Dirty = false;
            SetDefaultSelections();            
            StatusStripLabel.Text = this.fileName;
        }
        public HW7TopLevelForm() { }

        public HW7TopLevelForm(IUnityContainer container, 
            IDocumentRepository<ShapesDocument> repository)
            : base(container, repository) {

            InitializeComponent();
            ToolStripManager.Merge(this.MainMenuStrip, this.mainMenuStrip);
            this.MainMenuStrip = mainMenuStrip;
            this.ResizeRedraw = true;
            Application.Idle += Application_Idle;
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e) {
            document.Draw(e.Graphics);
        }

        private void SetDefaultSelections() {
            shapeToolStripMenuItem_DropDownItemClicked(shapeToolStripMenuItem,
                new ToolStripItemClickedEventArgs(
                    shapeToolStripMenuItem.DropDownItems[0]));
            penToolStripMenuItem_DropDownItemClicked(penToolStripMenuItem,
                new ToolStripItemClickedEventArgs(
                    penToolStripMenuItem.DropDownItems[0]));
            brushToolStripMenuItem_DropDownItemClicked(brushToolStripMenuItem,
                new ToolStripItemClickedEventArgs(
                    brushToolStripMenuItem.DropDownItems[0]));
        }
        protected override bool unsavedChanges => document.Dirty;
        
        protected override void saveFile(bool promptUser) {
            base.saveFile(promptUser);
            document.Dirty = false;
            StatusStripLabel.Text = fileName;
        }
        private void shapeToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            singleCheckedToolStripMenuItem_DropDownItemClicked(sender, e);
            template.Type = (ShapeType)Enum.Parse(typeof(ShapeType),
                e.ClickedItem.Text.Split(' ').Aggregate((a, b) => a + b));
        }
        private void penToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            singleCheckedToolStripMenuItem_DropDownItemClicked(sender, e);
            template.PenType = (PenType)Enum.Parse(typeof(PenType),
                e.ClickedItem.Text.Split(' ').Aggregate((a, b) => a + b));
        }
        private void brushToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            singleCheckedToolStripMenuItem_DropDownItemClicked(sender, e);
            template.BrushType = (BrushType)Enum.Parse(typeof(BrushType),
                e.ClickedItem.Text.Split(' ').Aggregate((a, b) => a + b));
        }
        private void singleCheckedToolStripMenuItem_DropDownItemClicked(
            object sender, ToolStripItemClickedEventArgs e) {
            (sender as ToolStripMenuItem).DropDownItems.Cast<ToolStripMenuItem>()
                .ToList().ForEach((item) => item.Checked = false);
            (e.ClickedItem as ToolStripMenuItem).Checked = true;
        }

        //protected override void oathToolStripMenuItem_Click(object sender, EventArgs e) {
        //    if (aboutDialog == null) {
        //        oathDialog = new OathDialog();
        //        oathDialog.StartPosition = FormStartPosition.Manual;
        //        oathDialog.Location = new Point(this.Location.X + this.Width,
        //                this.Location.Y);
        //        oathDialog.FormClosed += OathDialog_FormClosed;
        //        oathDialog.Show(this);
        //    }
        //}

        //protected override void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
        //    if (oathDialog == null) {
        //        aboutDialog = new Dialogs.AboutDialog();
        //        aboutDialog.StartPosition = FormStartPosition.Manual;
        //        aboutDialog.Location = new Point(this.Location.X,
        //            this.Location.Y + this.Height);
        //        aboutDialog.FormClosed += AboutDialog_FormClosed;
        //        aboutDialog.Show(this);
        //    }

        //}

        private void AboutDialog_FormClosed(object sender, FormClosedEventArgs e) {
            aboutDialog = null;
        }
        private void OathDialog_FormClosed(object sender, FormClosedEventArgs e) {
            oathDialog = null;
        }

        private void penColorToolStripMenuItem_Click(object sender, EventArgs e) {
            using (ColorDialog dlg = new ColorDialog()) {
                if (dlg.ShowDialog() == DialogResult.OK) {
                    template.PenColor = dlg.Color;
                }
            }
        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e) {
            using (ColorDialog dlg = new ColorDialog()) {
                if (dlg.ShowDialog() == DialogResult.OK) {
                    template.BrushColor = dlg.Color;
                }
            }
        }

        private PointF mouseDown = Point.Empty;

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ShapeOptionsDialog pForm = new ShapeOptionsDialog(this.document);


                if (pForm.ShowDialog(this) == DialogResult.OK) {
                    //if settings changed it will redraw the form
                    this.Refresh();
                }

            }
            if (e.Button == MouseButtons.Left) {
                drawingShape = template.Clone() as Shape;
                document.AddShape(drawingShape);
                mouseDown = e.Location;
            } else { return; }

        }

        private void Application_Idle(object sender, EventArgs e) {

            BrushColor.Text = "Brush-";
            BrushColor.Text += template.BrushColor;
            penColorBar.Text = "Pen-";
            penColorBar.Text += template.PenColor;
            shapeStatus.Text = "Shape-Type: ";
            shapeStatus.Text += template.Type;
            penStatusBar.Text = "Pen-Type: ";
            penStatusBar.Text += template.PenType;
            brushStatusBar.Text = "Brush-Type: ";
            brushStatusBar.Text += template.BrushType;
        }

        private void shapeOptionsToolStripMenuItem_Click(object sender, EventArgs e) {
            ShapeOptionsDialog pForm = new ShapeOptionsDialog(this.document);
            // pForm.Show(this);

            if (pForm.ShowDialog(this) == DialogResult.OK) {
                //if settings changed it will redraw the form
                this.Refresh();
            }
        }
        private void drawingPanel_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown == Point.Empty)
                return;

            drawingShape.Location = new PointF(
                Math.Min(mouseDown.X, e.Location.X),
                Math.Min(mouseDown.Y, e.Location.Y));
            drawingShape.Size = new SizeF(
                Math.Abs(mouseDown.X - e.Location.X),
                Math.Abs(mouseDown.Y - e.Location.Y));

            if (drawingShape.Size.Width > 0 && drawingShape.Size.Height > 0) {
                this.Invalidate(true);//do i need to refresh??
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e) {
            if (mouseDown != Point.Empty && mouseDown == e.Location) {
                document.RemoveShape(drawingShape);
            }
            mouseDown = Point.Empty;
            drawingShape = null;
        }
    }
}
