namespace Homework3ControlLib {
    partial class DialogBase {
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
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.courseInfo1 = new Homework3ControlLib.CourseInfo();
            this.teamNames = new Homework3ControlLib.TeamNames();
            this.SuspendLayout();
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(0, 83);
            this.mainContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(531, 176);
            this.mainContentPanel.TabIndex = 2;
            // 
            // courseInfo1
            // 
            this.courseInfo1.BackColor = System.Drawing.Color.Transparent;
            this.courseInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseInfo1.Location = new System.Drawing.Point(0, 0);
            this.courseInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.courseInfo1.Name = "courseInfo1";
            this.courseInfo1.Size = new System.Drawing.Size(531, 83);
            this.courseInfo1.TabIndex = 1;
            // 
            // teamNames
            // 
            this.teamNames.BackColor = System.Drawing.Color.Transparent;
            this.teamNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamNames.Location = new System.Drawing.Point(0, 259);
            this.teamNames.Margin = new System.Windows.Forms.Padding(5);
            this.teamNames.Name = "teamNames";
            this.teamNames.Size = new System.Drawing.Size(531, 156);
            this.teamNames.TabIndex = 0;
            // 
            // DialogBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 415);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.courseInfo1);
            this.Controls.Add(this.teamNames);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DialogBase";
            this.ResumeLayout(false);

        }

        #endregion

        private TeamNames teamNames;
        private CourseInfo courseInfo1;
        private System.Windows.Forms.Panel mainContentPanel;
    }
}