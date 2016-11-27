namespace WindowsProgramingHomework8.Dialogs {
    partial class ImageEditForm {
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPalettePanel = new System.Windows.Forms.Panel();
            this.imageViewPictureBox = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(716, 28);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // colorPalettePanel
            // 
            this.colorPalettePanel.AutoScroll = true;
            this.colorPalettePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPalettePanel.Location = new System.Drawing.Point(516, 28);
            this.colorPalettePanel.Name = "colorPalettePanel";
            this.colorPalettePanel.Size = new System.Drawing.Size(200, 470);
            this.colorPalettePanel.TabIndex = 1;
            // 
            // imageViewPictureBox
            // 
            this.imageViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewPictureBox.Location = new System.Drawing.Point(0, 28);
            this.imageViewPictureBox.Name = "imageViewPictureBox";
            this.imageViewPictureBox.Size = new System.Drawing.Size(516, 470);
            this.imageViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageViewPictureBox.TabIndex = 2;
            this.imageViewPictureBox.TabStop = false;
            // 
            // ImageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 498);
            this.Controls.Add(this.imageViewPictureBox);
            this.Controls.Add(this.colorPalettePanel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "ImageEditForm";
            this.Text = "ImageEditForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel colorPalettePanel;
        private System.Windows.Forms.PictureBox imageViewPictureBox;
    }
}