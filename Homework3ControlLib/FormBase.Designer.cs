namespace Homework3ControlLib {
    partial class FormBase<T> {
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
            this.components = new System.ComponentModel.Container();
            this.baseFormContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.baseFormMenu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseFormContextMenu
            // 
            this.baseFormContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseFormContextMenu.Name = "baseFormContextMenu";
            this.baseFormContextMenu.Size = new System.Drawing.Size(67, 4);
            // 
            // baseFormMenu
            // 
            this.baseFormMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.baseFormMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.baseFormMenu.Location = new System.Drawing.Point(0, 0);
            this.baseFormMenu.Name = "baseFormMenu";
            this.baseFormMenu.ShowItemToolTips = true;
            this.baseFormMenu.Size = new System.Drawing.Size(379, 28);
            this.baseFormMenu.TabIndex = 1;
            this.baseFormMenu.Text = "baseFormMenu";
            this.baseFormMenu.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.oathToolStripMenuItem.Text = "Oath ";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.closeToolStripMenuItem.Text = "Close Child";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.fileCloseMenuItem_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.ContextMenuStrip = this.baseFormContextMenu;
            this.Controls.Add(this.baseFormMenu);
            this.MainMenuStrip = this.baseFormMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBase";
            this.Text = "Main Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseUp);
            this.baseFormMenu.ResumeLayout(false);
            this.baseFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip baseFormContextMenu;
        private System.Windows.Forms.MenuStrip baseFormMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}