namespace WindowsProgramingHomework8.Dialogs
{
    partial class TextOptionsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fontLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label rotationLabel;
            System.Windows.Forms.Label textToDrawLabel;
            this.textsDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textsComboBox = new System.Windows.Forms.ComboBox();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.textToDrawTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChangeFont = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            fontLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            rotationLabel = new System.Windows.Forms.Label();
            textToDrawLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textsDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Location = new System.Drawing.Point(19, 114);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new System.Drawing.Size(40, 17);
            fontLabel.TabIndex = 1;
            fontLabel.Text = "Font:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(19, 161);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(66, 17);
            locationLabel.TabIndex = 3;
            locationLabel.Text = "Location:";
            // 
            // rotationLabel
            // 
            rotationLabel.AutoSize = true;
            rotationLabel.Location = new System.Drawing.Point(20, 210);
            rotationLabel.Name = "rotationLabel";
            rotationLabel.Size = new System.Drawing.Size(65, 17);
            rotationLabel.TabIndex = 5;
            rotationLabel.Text = "Rotation:";
            // 
            // textToDrawLabel
            // 
            textToDrawLabel.AutoSize = true;
            textToDrawLabel.Location = new System.Drawing.Point(20, 258);
            textToDrawLabel.Name = "textToDrawLabel";
            textToDrawLabel.Size = new System.Drawing.Size(39, 17);
            textToDrawLabel.TabIndex = 7;
            textToDrawLabel.Text = "Text:";
            // 
            // textsDocumentBindingSource
            // 
            this.textsDocumentBindingSource.DataSource = typeof(WindowsProgramingHomework8.Entities.TextsDocument);
            // 
            // textsBindingSource
            // 
            this.textsBindingSource.DataMember = "Texts";
            this.textsBindingSource.DataSource = this.textsDocumentBindingSource;
            // 
            // textsComboBox
            // 
            this.textsComboBox.DataSource = this.textsBindingSource;
            this.textsComboBox.DisplayMember = "TextToDraw";
            this.textsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textsComboBox.FormattingEnabled = true;
            this.textsComboBox.Location = new System.Drawing.Point(22, 50);
            this.textsComboBox.Name = "textsComboBox";
            this.textsComboBox.Size = new System.Drawing.Size(198, 24);
            this.textsComboBox.TabIndex = 0;
            this.textsComboBox.ValueMember = "Font";
            this.textsComboBox.SelectedIndexChanged += new System.EventHandler(this.textsComboBox_SelectedIndexChanged);
            // 
            // fontTextBox
            // 
            this.fontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textsBindingSource, "Font", true));
            this.fontTextBox.Location = new System.Drawing.Point(91, 114);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.ReadOnly = true;
            this.fontTextBox.Size = new System.Drawing.Size(129, 22);
            this.fontTextBox.TabIndex = 2;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textsBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(91, 161);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(129, 22);
            this.locationTextBox.TabIndex = 4;
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textsBindingSource, "Rotation", true));
            this.rotationTextBox.Location = new System.Drawing.Point(91, 210);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(129, 22);
            this.rotationTextBox.TabIndex = 6;
            // 
            // textToDrawTextBox
            // 
            this.textToDrawTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textsBindingSource, "TextToDraw", true));
            this.textToDrawTextBox.Location = new System.Drawing.Point(91, 255);
            this.textToDrawTextBox.Name = "textToDrawTextBox";
            this.textToDrawTextBox.Size = new System.Drawing.Size(129, 22);
            this.textToDrawTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Texts";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrevious.Location = new System.Drawing.Point(238, 49);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 24);
            this.buttonPrevious.TabIndex = 18;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNext.Location = new System.Drawing.Point(283, 49);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 24);
            this.buttonNext.TabIndex = 19;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(145, 319);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 33);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(247, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChangeFont
            // 
            this.buttonChangeFont.Location = new System.Drawing.Point(247, 114);
            this.buttonChangeFont.Name = "buttonChangeFont";
            this.buttonChangeFont.Size = new System.Drawing.Size(75, 26);
            this.buttonChangeFont.TabIndex = 27;
            this.buttonChangeFont.Text = "Change";
            this.buttonChangeFont.UseVisualStyleBackColor = true;
            this.buttonChangeFont.Click += new System.EventHandler(this.buttonChangeFont_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(25, 319);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 33);
            this.buttonApply.TabIndex = 28;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // TextOptionsDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(349, 379);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonChangeFont);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.label1);
            this.Controls.Add(textToDrawLabel);
            this.Controls.Add(this.textToDrawTextBox);
            this.Controls.Add(rotationLabel);
            this.Controls.Add(this.rotationTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(fontLabel);
            this.Controls.Add(this.fontTextBox);
            this.Controls.Add(this.textsComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextOptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Options";
            ((System.ComponentModel.ISupportInitialize)(this.textsDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource textsDocumentBindingSource;
        private System.Windows.Forms.BindingSource textsBindingSource;
        private System.Windows.Forms.ComboBox textsComboBox;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.TextBox textToDrawTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChangeFont;
        private System.Windows.Forms.Button buttonApply;
    }
}