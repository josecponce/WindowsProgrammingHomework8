namespace Homework7.Dialogs
{
    partial class ShapeOptionsDialog
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
            System.Windows.Forms.Label shapeBrushColorLabel;
            System.Windows.Forms.Label shapeLocationLabel;
            System.Windows.Forms.Label shapePenColorLabel;
            System.Windows.Forms.Label shapeSizeLabel;
            System.Windows.Forms.Label shapeTypeLabel;
            System.Windows.Forms.Label label1;
            this.labelPenTypes = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelBrushTypes = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.shapesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapesComboBox = new System.Windows.Forms.ComboBox();
            this.brushColorTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.penColorTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.buttonChangePenColor = new System.Windows.Forms.Button();
            this.buttonChangeBrushColor = new System.Windows.Forms.Button();
            this.brushTypeTextBox = new System.Windows.Forms.TextBox();
            this.penTypeTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxShapeType = new System.Windows.Forms.GroupBox();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.groupBoxPen = new System.Windows.Forms.GroupBox();
            this.radioButtonPenCompound = new System.Windows.Forms.RadioButton();
            this.radioButtonPenDashed = new System.Windows.Forms.RadioButton();
            this.radioButtonPenSolid = new System.Windows.Forms.RadioButton();
            this.groupBoxBrush = new System.Windows.Forms.GroupBox();
            this.radioButtonBrushHatshed = new System.Windows.Forms.RadioButton();
            this.radioButtonBrushLinearGradient = new System.Windows.Forms.RadioButton();
            this.radioButtonBrushSolid = new System.Windows.Forms.RadioButton();
            this.shapesDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            shapeBrushColorLabel = new System.Windows.Forms.Label();
            shapeLocationLabel = new System.Windows.Forms.Label();
            shapePenColorLabel = new System.Windows.Forms.Label();
            shapeSizeLabel = new System.Windows.Forms.Label();
            shapeTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).BeginInit();
            this.groupBoxShapeType.SuspendLayout();
            this.groupBoxPen.SuspendLayout();
            this.groupBoxBrush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeBrushColorLabel
            // 
            shapeBrushColorLabel.AutoSize = true;
            shapeBrushColorLabel.Location = new System.Drawing.Point(37, 341);
            shapeBrushColorLabel.Name = "shapeBrushColorLabel";
            shapeBrushColorLabel.Size = new System.Drawing.Size(86, 17);
            shapeBrushColorLabel.TabIndex = 7;
            shapeBrushColorLabel.Text = "Brush Color:";
            // 
            // shapeLocationLabel
            // 
            shapeLocationLabel.AutoSize = true;
            shapeLocationLabel.Location = new System.Drawing.Point(37, 385);
            shapeLocationLabel.Name = "shapeLocationLabel";
            shapeLocationLabel.Size = new System.Drawing.Size(111, 17);
            shapeLocationLabel.TabIndex = 9;
            shapeLocationLabel.Text = "Shape Location:";
            // 
            // shapePenColorLabel
            // 
            shapePenColorLabel.AutoSize = true;
            shapePenColorLabel.Location = new System.Drawing.Point(37, 302);
            shapePenColorLabel.Name = "shapePenColorLabel";
            shapePenColorLabel.Size = new System.Drawing.Size(74, 17);
            shapePenColorLabel.TabIndex = 11;
            shapePenColorLabel.Text = "Pen Color:";
            // 
            // shapeSizeLabel
            // 
            shapeSizeLabel.AutoSize = true;
            shapeSizeLabel.Location = new System.Drawing.Point(39, 428);
            shapeSizeLabel.Name = "shapeSizeLabel";
            shapeSizeLabel.Size = new System.Drawing.Size(84, 17);
            shapeSizeLabel.TabIndex = 13;
            shapeSizeLabel.Text = "Shape Size:";
            // 
            // shapeTypeLabel
            // 
            shapeTypeLabel.AutoSize = true;
            shapeTypeLabel.Location = new System.Drawing.Point(37, 115);
            shapeTypeLabel.Name = "shapeTypeLabel";
            shapeTypeLabel.Size = new System.Drawing.Size(89, 17);
            shapeTypeLabel.TabIndex = 15;
            shapeTypeLabel.Text = "Shape Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 17);
            label1.TabIndex = 18;
            label1.Text = "Shapes:";
            // 
            // labelPenTypes
            // 
            this.labelPenTypes.AutoSize = true;
            this.labelPenTypes.Location = new System.Drawing.Point(37, 181);
            this.labelPenTypes.Name = "labelPenTypes";
            this.labelPenTypes.Size = new System.Drawing.Size(76, 17);
            this.labelPenTypes.TabIndex = 1;
            this.labelPenTypes.Text = "Pen Types";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(401, 422);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 33);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(511, 422);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelBrushTypes
            // 
            this.labelBrushTypes.AutoSize = true;
            this.labelBrushTypes.Location = new System.Drawing.Point(37, 249);
            this.labelBrushTypes.Name = "labelBrushTypes";
            this.labelBrushTypes.Size = new System.Drawing.Size(88, 17);
            this.labelBrushTypes.TabIndex = 5;
            this.labelBrushTypes.Text = "Brush Types";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNext.Location = new System.Drawing.Point(511, 35);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 33);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrevious.Location = new System.Drawing.Point(401, 35);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 33);
            this.buttonPrevious.TabIndex = 17;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // shapesBindingSource
            // 
            this.shapesBindingSource.DataMember = "Shapes";
            this.shapesBindingSource.DataSource = this.shapesDocumentBindingSource;
            // 
            // shapesComboBox
            // 
            this.shapesComboBox.DataSource = this.shapesBindingSource;
            this.shapesComboBox.DisplayMember = "BrushColor";
            this.shapesComboBox.FormattingEnabled = true;
            this.shapesComboBox.Location = new System.Drawing.Point(40, 44);
            this.shapesComboBox.Name = "shapesComboBox";
            this.shapesComboBox.Size = new System.Drawing.Size(184, 24);
            this.shapesComboBox.TabIndex = 17;
            this.shapesComboBox.ValueMember = "BrushColor";
            this.shapesComboBox.SelectedIndexChanged += new System.EventHandler(this.shapesComboBox_SelectedIndexChanged);
            // 
            // brushColorTextBox
            // 
            this.brushColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapesBindingSource, "BrushColor", true));
            this.brushColorTextBox.Location = new System.Drawing.Point(144, 338);
            this.brushColorTextBox.Name = "brushColorTextBox";
            this.brushColorTextBox.ReadOnly = true;
            this.brushColorTextBox.Size = new System.Drawing.Size(124, 22);
            this.brushColorTextBox.TabIndex = 19;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapesBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(144, 382);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(124, 22);
            this.locationTextBox.TabIndex = 21;
            // 
            // penColorTextBox
            // 
            this.penColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapesBindingSource, "PenColor", true));
            this.penColorTextBox.Location = new System.Drawing.Point(144, 302);
            this.penColorTextBox.Name = "penColorTextBox";
            this.penColorTextBox.ReadOnly = true;
            this.penColorTextBox.Size = new System.Drawing.Size(124, 22);
            this.penColorTextBox.TabIndex = 22;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapesBindingSource, "Size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(144, 428);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(124, 22);
            this.sizeTextBox.TabIndex = 24;
            // 
            // buttonChangePenColor
            // 
            this.buttonChangePenColor.Location = new System.Drawing.Point(299, 302);
            this.buttonChangePenColor.Name = "buttonChangePenColor";
            this.buttonChangePenColor.Size = new System.Drawing.Size(75, 26);
            this.buttonChangePenColor.TabIndex = 26;
            this.buttonChangePenColor.Text = "Change";
            this.buttonChangePenColor.UseVisualStyleBackColor = true;
            this.buttonChangePenColor.Click += new System.EventHandler(this.buttonChangePenColor_Click);
            // 
            // buttonChangeBrushColor
            // 
            this.buttonChangeBrushColor.Location = new System.Drawing.Point(299, 334);
            this.buttonChangeBrushColor.Name = "buttonChangeBrushColor";
            this.buttonChangeBrushColor.Size = new System.Drawing.Size(75, 26);
            this.buttonChangeBrushColor.TabIndex = 27;
            this.buttonChangeBrushColor.Text = "Change";
            this.buttonChangeBrushColor.UseVisualStyleBackColor = true;
            this.buttonChangeBrushColor.Click += new System.EventHandler(this.buttonChangeBrushColor_Click);
            // 
            // brushTypeTextBox
            // 
            this.brushTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapesBindingSource, "BrushType", true));
            this.brushTypeTextBox.Location = new System.Drawing.Point(144, 243);
            this.brushTypeTextBox.Name = "brushTypeTextBox";
            this.brushTypeTextBox.ReadOnly = true;
            this.brushTypeTextBox.Size = new System.Drawing.Size(124, 22);
            this.brushTypeTextBox.TabIndex = 28;
            this.brushTypeTextBox.TextChanged += new System.EventHandler(this.brushTypeTextBox_TextChanged);
            // 
            // penTypeTextBox
            // 
            this.penTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapesBindingSource, "PenType", true));
            this.penTypeTextBox.Location = new System.Drawing.Point(144, 178);
            this.penTypeTextBox.Name = "penTypeTextBox";
            this.penTypeTextBox.ReadOnly = true;
            this.penTypeTextBox.Size = new System.Drawing.Size(124, 22);
            this.penTypeTextBox.TabIndex = 29;
            this.penTypeTextBox.TextChanged += new System.EventHandler(this.penTypeTextBox_TextChanged);
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapesBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(144, 111);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(124, 22);
            this.typeTextBox.TabIndex = 30;
            this.typeTextBox.TextChanged += new System.EventHandler(this.typeTextBox_TextChanged);
            // 
            // groupBoxShapeType
            // 
            this.groupBoxShapeType.Controls.Add(this.radioButtonCustom);
            this.groupBoxShapeType.Controls.Add(this.radioButtonRectangle);
            this.groupBoxShapeType.Controls.Add(this.radioButtonEllipse);
            this.groupBoxShapeType.Location = new System.Drawing.Point(299, 91);
            this.groupBoxShapeType.Name = "groupBoxShapeType";
            this.groupBoxShapeType.Size = new System.Drawing.Size(318, 60);
            this.groupBoxShapeType.TabIndex = 31;
            this.groupBoxShapeType.TabStop = false;
            this.groupBoxShapeType.Text = "Change Type";
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(203, 21);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(76, 21);
            this.radioButtonCustom.TabIndex = 2;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.radioButtonCustom_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(102, 20);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(93, 21);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(7, 22);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(70, 21);
            this.radioButtonEllipse.TabIndex = 0;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Ellipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonEllipse_CheckedChanged);
            // 
            // groupBoxPen
            // 
            this.groupBoxPen.Controls.Add(this.radioButtonPenCompound);
            this.groupBoxPen.Controls.Add(this.radioButtonPenDashed);
            this.groupBoxPen.Controls.Add(this.radioButtonPenSolid);
            this.groupBoxPen.Location = new System.Drawing.Point(299, 157);
            this.groupBoxPen.Name = "groupBoxPen";
            this.groupBoxPen.Size = new System.Drawing.Size(318, 60);
            this.groupBoxPen.TabIndex = 32;
            this.groupBoxPen.TabStop = false;
            this.groupBoxPen.Text = "Change Pen";
            // 
            // radioButtonPenCompound
            // 
            this.radioButtonPenCompound.AutoSize = true;
            this.radioButtonPenCompound.Location = new System.Drawing.Point(203, 24);
            this.radioButtonPenCompound.Name = "radioButtonPenCompound";
            this.radioButtonPenCompound.Size = new System.Drawing.Size(97, 21);
            this.radioButtonPenCompound.TabIndex = 2;
            this.radioButtonPenCompound.TabStop = true;
            this.radioButtonPenCompound.Text = "Compound";
            this.radioButtonPenCompound.UseVisualStyleBackColor = true;
            this.radioButtonPenCompound.CheckedChanged += new System.EventHandler(this.radioButtonPenCompound_CheckedChanged);
            // 
            // radioButtonPenDashed
            // 
            this.radioButtonPenDashed.AutoSize = true;
            this.radioButtonPenDashed.Location = new System.Drawing.Point(78, 24);
            this.radioButtonPenDashed.Name = "radioButtonPenDashed";
            this.radioButtonPenDashed.Size = new System.Drawing.Size(125, 21);
            this.radioButtonPenDashed.TabIndex = 1;
            this.radioButtonPenDashed.TabStop = true;
            this.radioButtonPenDashed.Text = "CustomDashed";
            this.radioButtonPenDashed.UseVisualStyleBackColor = true;
            this.radioButtonPenDashed.CheckedChanged += new System.EventHandler(this.radioButtonPenDashed_CheckedChanged);
            // 
            // radioButtonPenSolid
            // 
            this.radioButtonPenSolid.AutoSize = true;
            this.radioButtonPenSolid.Location = new System.Drawing.Point(7, 22);
            this.radioButtonPenSolid.Name = "radioButtonPenSolid";
            this.radioButtonPenSolid.Size = new System.Drawing.Size(60, 21);
            this.radioButtonPenSolid.TabIndex = 0;
            this.radioButtonPenSolid.TabStop = true;
            this.radioButtonPenSolid.Text = "Solid";
            this.radioButtonPenSolid.UseVisualStyleBackColor = true;
            this.radioButtonPenSolid.CheckedChanged += new System.EventHandler(this.radioButtonPenSolid_CheckedChanged);
            // 
            // groupBoxBrush
            // 
            this.groupBoxBrush.Controls.Add(this.radioButtonBrushHatshed);
            this.groupBoxBrush.Controls.Add(this.radioButtonBrushLinearGradient);
            this.groupBoxBrush.Controls.Add(this.radioButtonBrushSolid);
            this.groupBoxBrush.Location = new System.Drawing.Point(299, 223);
            this.groupBoxBrush.Name = "groupBoxBrush";
            this.groupBoxBrush.Size = new System.Drawing.Size(318, 60);
            this.groupBoxBrush.TabIndex = 33;
            this.groupBoxBrush.TabStop = false;
            this.groupBoxBrush.Text = "Change Brush";
            // 
            // radioButtonBrushHatshed
            // 
            this.radioButtonBrushHatshed.AutoSize = true;
            this.radioButtonBrushHatshed.Location = new System.Drawing.Point(203, 20);
            this.radioButtonBrushHatshed.Name = "radioButtonBrushHatshed";
            this.radioButtonBrushHatshed.Size = new System.Drawing.Size(66, 21);
            this.radioButtonBrushHatshed.TabIndex = 2;
            this.radioButtonBrushHatshed.TabStop = true;
            this.radioButtonBrushHatshed.Text = "Hatch";
            this.radioButtonBrushHatshed.UseVisualStyleBackColor = true;
            this.radioButtonBrushHatshed.CheckedChanged += new System.EventHandler(this.radioButtonBrushHatshed_CheckedChanged);
            // 
            // radioButtonBrushLinearGradient
            // 
            this.radioButtonBrushLinearGradient.AutoSize = true;
            this.radioButtonBrushLinearGradient.Location = new System.Drawing.Point(78, 21);
            this.radioButtonBrushLinearGradient.Name = "radioButtonBrushLinearGradient";
            this.radioButtonBrushLinearGradient.Size = new System.Drawing.Size(124, 21);
            this.radioButtonBrushLinearGradient.TabIndex = 1;
            this.radioButtonBrushLinearGradient.TabStop = true;
            this.radioButtonBrushLinearGradient.Text = "LinearGradient";
            this.radioButtonBrushLinearGradient.UseVisualStyleBackColor = true;
            this.radioButtonBrushLinearGradient.CheckedChanged += new System.EventHandler(this.radioButtonBrushLinearGradient_CheckedChanged);
            // 
            // radioButtonBrushSolid
            // 
            this.radioButtonBrushSolid.AutoSize = true;
            this.radioButtonBrushSolid.Location = new System.Drawing.Point(7, 22);
            this.radioButtonBrushSolid.Name = "radioButtonBrushSolid";
            this.radioButtonBrushSolid.Size = new System.Drawing.Size(60, 21);
            this.radioButtonBrushSolid.TabIndex = 0;
            this.radioButtonBrushSolid.TabStop = true;
            this.radioButtonBrushSolid.Text = "Solid";
            this.radioButtonBrushSolid.UseVisualStyleBackColor = true;
            this.radioButtonBrushSolid.CheckedChanged += new System.EventHandler(this.radioButtonBrushSolid_CheckedChanged);
            // 
            // shapesDocumentBindingSource
            // 
            this.shapesDocumentBindingSource.DataSource = typeof(Homework7.Entities.ShapesDocument);
            // 
            // ShapeOptionsDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(629, 495);
            this.Controls.Add(this.groupBoxBrush);
            this.Controls.Add(this.groupBoxPen);
            this.Controls.Add(this.groupBoxShapeType);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.penTypeTextBox);
            this.Controls.Add(this.brushTypeTextBox);
            this.Controls.Add(this.buttonChangeBrushColor);
            this.Controls.Add(this.buttonChangePenColor);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.penColorTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.brushColorTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.shapesComboBox);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(shapeTypeLabel);
            this.Controls.Add(shapeSizeLabel);
            this.Controls.Add(shapePenColorLabel);
            this.Controls.Add(shapeLocationLabel);
            this.Controls.Add(shapeBrushColorLabel);
            this.Controls.Add(this.labelBrushTypes);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelPenTypes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapeOptionsDialog";
            this.Text = "Shape Options";
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).EndInit();
            this.groupBoxShapeType.ResumeLayout(false);
            this.groupBoxShapeType.PerformLayout();
            this.groupBoxPen.ResumeLayout(false);
            this.groupBoxPen.PerformLayout();
            this.groupBoxBrush.ResumeLayout(false);
            this.groupBoxBrush.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPenTypes;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelBrushTypes;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.BindingSource shapesDocumentBindingSource;
        private System.Windows.Forms.BindingSource shapesBindingSource;
        private System.Windows.Forms.ComboBox shapesComboBox;
        private System.Windows.Forms.TextBox brushColorTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox penColorTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button buttonChangePenColor;
        private System.Windows.Forms.Button buttonChangeBrushColor;
        private System.Windows.Forms.TextBox brushTypeTextBox;
        private System.Windows.Forms.TextBox penTypeTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.GroupBox groupBoxShapeType;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.GroupBox groupBoxPen;
        private System.Windows.Forms.RadioButton radioButtonPenCompound;
        private System.Windows.Forms.RadioButton radioButtonPenDashed;
        private System.Windows.Forms.RadioButton radioButtonPenSolid;
        private System.Windows.Forms.GroupBox groupBoxBrush;
        private System.Windows.Forms.RadioButton radioButtonBrushHatshed;
        private System.Windows.Forms.RadioButton radioButtonBrushLinearGradient;
        private System.Windows.Forms.RadioButton radioButtonBrushSolid;
    }
}