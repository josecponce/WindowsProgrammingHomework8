namespace WindowsProgramingHomework8.Dialogs {
    partial class SearchDialog {
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
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.stopSearchButton = new System.Windows.Forms.Button();
            this.pauseSearchButton = new System.Windows.Forms.Button();
            this.startSearchButton = new System.Windows.Forms.Button();
            this.fileExtensionDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filesListBox
            // 
            this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 16;
            this.filesListBox.Location = new System.Drawing.Point(12, 12);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(494, 180);
            this.filesListBox.TabIndex = 0;
            this.filesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesListBox_MouseDoubleClick);
            // 
            // stopSearchButton
            // 
            this.stopSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopSearchButton.Enabled = false;
            this.stopSearchButton.Location = new System.Drawing.Point(363, 282);
            this.stopSearchButton.Name = "stopSearchButton";
            this.stopSearchButton.Size = new System.Drawing.Size(110, 56);
            this.stopSearchButton.TabIndex = 1;
            this.stopSearchButton.Text = "Stop";
            this.stopSearchButton.UseVisualStyleBackColor = true;
            this.stopSearchButton.Click += new System.EventHandler(this.stopSearchButton_Click);
            // 
            // pauseSearchButton
            // 
            this.pauseSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pauseSearchButton.Enabled = false;
            this.pauseSearchButton.Location = new System.Drawing.Point(204, 282);
            this.pauseSearchButton.Name = "pauseSearchButton";
            this.pauseSearchButton.Size = new System.Drawing.Size(110, 56);
            this.pauseSearchButton.TabIndex = 2;
            this.pauseSearchButton.Text = "Pause";
            this.pauseSearchButton.UseVisualStyleBackColor = true;
            this.pauseSearchButton.Click += new System.EventHandler(this.pauseSearchButton_Click);
            // 
            // startSearchButton
            // 
            this.startSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startSearchButton.Location = new System.Drawing.Point(44, 282);
            this.startSearchButton.Name = "startSearchButton";
            this.startSearchButton.Size = new System.Drawing.Size(110, 56);
            this.startSearchButton.TabIndex = 3;
            this.startSearchButton.Text = "Start";
            this.startSearchButton.UseVisualStyleBackColor = true;
            this.startSearchButton.Click += new System.EventHandler(this.startSearchButton_Click);
            // 
            // fileExtensionDropDown
            // 
            this.fileExtensionDropDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fileExtensionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileExtensionDropDown.FormattingEnabled = true;
            this.fileExtensionDropDown.Items.AddRange(new object[] {
            "*.txt (Plain Text File)",
            "*.htm (HyperText Markup Lanuguage File)",
            "*.html (HyperText Markup Lanuguage File)"});
            this.fileExtensionDropDown.Location = new System.Drawing.Point(111, 226);
            this.fileExtensionDropDown.Name = "fileExtensionDropDown";
            this.fileExtensionDropDown.Size = new System.Drawing.Size(288, 24);
            this.fileExtensionDropDown.TabIndex = 4;
            this.fileExtensionDropDown.SelectedIndexChanged += new System.EventHandler(this.fileExtensionDropDown_SelectedIndexChanged);
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 363);
            this.Controls.Add(this.fileExtensionDropDown);
            this.Controls.Add(this.startSearchButton);
            this.Controls.Add(this.pauseSearchButton);
            this.Controls.Add(this.stopSearchButton);
            this.Controls.Add(this.filesListBox);
            this.MinimumSize = new System.Drawing.Size(536, 410);
            this.Name = "SearchDialog";
            this.Text = "SearchDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDialog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Button pauseSearchButton;
        private System.Windows.Forms.Button startSearchButton;
        private System.Windows.Forms.Button stopSearchButton;
        private System.Windows.Forms.ComboBox fileExtensionDropDown;
    }
}