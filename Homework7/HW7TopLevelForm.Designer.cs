using System.Windows.Forms;

namespace Homework7 {
    partial class HW7TopLevelForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW7TopLevelForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrushColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.penColorBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.penStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.shapeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.brushStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.penToolStripMenuItem,
            this.brushToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.shapeOptionsToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 24);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.mainMenuStrip.ShowItemToolTips = true;
            this.mainMenuStrip.Size = new System.Drawing.Size(801, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.customToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.shapeToolStripMenuItem.Text = "Shape";
            this.shapeToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.shapeToolStripMenuItem_DropDownItemClicked);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.customDashedToolStripMenuItem,
            this.compountToolStripMenuItem});
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.penToolStripMenuItem.Text = "Pen";
            this.penToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.penToolStripMenuItem_DropDownItemClicked);
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            // 
            // customDashedToolStripMenuItem
            // 
            this.customDashedToolStripMenuItem.Name = "customDashedToolStripMenuItem";
            this.customDashedToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.customDashedToolStripMenuItem.Text = "Custom Dashed";
            // 
            // compountToolStripMenuItem
            // 
            this.compountToolStripMenuItem.Name = "compountToolStripMenuItem";
            this.compountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.compountToolStripMenuItem.Text = "Compound";
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem1,
            this.hatchToolStripMenuItem,
            this.linearGradientToolStripMenuItem});
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.brushToolStripMenuItem.Text = "Brush";
            this.brushToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.brushToolStripMenuItem_DropDownItemClicked);
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.solidToolStripMenuItem1.Text = "Solid";
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hatchToolStripMenuItem.Text = "Hatch";
            // 
            // linearGradientToolStripMenuItem
            // 
            this.linearGradientToolStripMenuItem.Name = "linearGradientToolStripMenuItem";
            this.linearGradientToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.linearGradientToolStripMenuItem.Text = "Linear Gradient";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penColorToolStripMenuItem,
            this.brushColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // penColorToolStripMenuItem
            // 
            this.penColorToolStripMenuItem.Name = "penColorToolStripMenuItem";
            this.penColorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.penColorToolStripMenuItem.Text = "Pen Color";
            this.penColorToolStripMenuItem.Click += new System.EventHandler(this.penColorToolStripMenuItem_Click);
            // 
            // brushColorToolStripMenuItem
            // 
            this.brushColorToolStripMenuItem.Name = "brushColorToolStripMenuItem";
            this.brushColorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.brushColorToolStripMenuItem.Text = "Brush Color";
            this.brushColorToolStripMenuItem.Click += new System.EventHandler(this.brushColorToolStripMenuItem_Click);
            // 
            // shapeOptionsToolStripMenuItem
            // 
            this.shapeOptionsToolStripMenuItem.Name = "shapeOptionsToolStripMenuItem";
            this.shapeOptionsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.shapeOptionsToolStripMenuItem.Text = "Shape Options";
            this.shapeOptionsToolStripMenuItem.Click += new System.EventHandler(this.shapeOptionsToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripButton,
            this.openFileToolStripButton,
            this.saveFileToolStripButton,
            this.saveAsFileToolStripButton,
            this.exitToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 48);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(801, 27);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip";
            // 
            // newFileToolStripButton
            // 
            this.newFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newFileToolStripButton.Image")));
            this.newFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileToolStripButton.Name = "newFileToolStripButton";
            this.newFileToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newFileToolStripButton.Text = "newFileToolStripButton";
            this.newFileToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFileToolStripButton
            // 
            this.openFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripButton.Image")));
            this.openFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileToolStripButton.Name = "openFileToolStripButton";
            this.openFileToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openFileToolStripButton.Text = "openFileToolStripButton";
            this.openFileToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileToolStripButton
            // 
            this.saveFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileToolStripButton.Image")));
            this.saveFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileToolStripButton.Name = "saveFileToolStripButton";
            this.saveFileToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveFileToolStripButton.Text = "saveFileToolStripButton";
            this.saveFileToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsFileToolStripButton
            // 
            this.saveAsFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsFileToolStripButton.Image")));
            this.saveAsFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsFileToolStripButton.Name = "saveAsFileToolStripButton";
            this.saveAsFileToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveAsFileToolStripButton.Text = "saveAsFileToolStripButton";
            this.saveAsFileToolStripButton.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripButton.Image")));
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.exitToolStripButton.Text = "exitToolStripButton";
            this.exitToolStripButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel,
            this.BrushColor,
            this.penColorBar,
            this.penStatusBar,
            this.shapeStatus,
            this.brushStatusBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 414);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusStrip.Size = new System.Drawing.Size(801, 22);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusStripLabel.Text = "Status";
            // 
            // BrushColor
            // 
            this.BrushColor.Name = "BrushColor";
            this.BrushColor.Size = new System.Drawing.Size(66, 17);
            this.BrushColor.Text = "BrushColor";
            // 
            // penColorBar
            // 
            this.penColorBar.Name = "penColorBar";
            this.penColorBar.Size = new System.Drawing.Size(56, 17);
            this.penColorBar.Text = "penColor";
            // 
            // penStatusBar
            // 
            this.penStatusBar.Name = "penStatusBar";
            this.penStatusBar.Size = new System.Drawing.Size(64, 17);
            this.penStatusBar.Text = "Pen-Type: ";
            // 
            // shapeStatus
            // 
            this.shapeStatus.Name = "shapeStatus";
            this.shapeStatus.Size = new System.Drawing.Size(45, 17);
            this.shapeStatus.Text = "Shape: ";
            // 
            // brushStatusBar
            // 
            this.brushStatusBar.Name = "brushStatusBar";
            this.brushStatusBar.Size = new System.Drawing.Size(40, 17);
            this.brushStatusBar.Text = "Brush:";
            // 
            // drawingPanel
            // 
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(0, 75);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(801, 339);
            this.drawingPanel.TabIndex = 6;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // TopLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 436);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TopLevelForm";
            this.ShowIcon = false;
            this.Controls.SetChildIndex(this.mainMenuStrip, 0);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.StatusStrip, 0);
            this.Controls.SetChildIndex(this.drawingPanel, 0);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customDashedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearGradientToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripButton newFileToolStripButton;
        private ToolStripButton openFileToolStripButton;
        private ToolStripButton saveFileToolStripButton;
        private ToolStripButton saveAsFileToolStripButton;
        private ToolStripButton exitToolStripButton;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel StatusStripLabel;
        private ToolStripMenuItem shapeOptionsToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem penColorToolStripMenuItem;
        private ToolStripMenuItem brushColorToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private Panel drawingPanel;
        private ToolStripStatusLabel BrushColor;
        private ToolStripStatusLabel penStatusBar;
        private ToolStripStatusLabel shapeStatus;
        private ToolStripStatusLabel brushStatusBar;
        private ToolStripStatusLabel penColorBar;
    }
}

