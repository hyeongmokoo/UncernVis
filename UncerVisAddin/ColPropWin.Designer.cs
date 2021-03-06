﻿namespace UncerVisAddin
{
    partial class ColPropWin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudLinewidth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.picSymbolColor = new System.Windows.Forms.PictureBox();
            this.picLineColor = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nudSymbolSize = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewLayer = new System.Windows.Forms.TextBox();
            this.chkNewLayer = new System.Windows.Forms.CheckBox();
            this.cboUField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboValueField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSourceLayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMinVar = new System.Windows.Forms.NumericUpDown();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMethods = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinewidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSymbolColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbolSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudLinewidth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.picSymbolColor);
            this.groupBox1.Controls.Add(this.picLineColor);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.nudSymbolSize);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(196, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 140);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proportional Symbol";
            // 
            // nudLinewidth
            // 
            this.nudLinewidth.DecimalPlaces = 1;
            this.nudLinewidth.Location = new System.Drawing.Point(102, 81);
            this.nudLinewidth.Name = "nudLinewidth";
            this.nudLinewidth.Size = new System.Drawing.Size(55, 20);
            this.nudLinewidth.TabIndex = 13;
            this.nudLinewidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Outline width: ";
            // 
            // picSymbolColor
            // 
            this.picSymbolColor.BackColor = System.Drawing.Color.Red;
            this.picSymbolColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSymbolColor.Location = new System.Drawing.Point(101, 52);
            this.picSymbolColor.Name = "picSymbolColor";
            this.picSymbolColor.Size = new System.Drawing.Size(55, 21);
            this.picSymbolColor.TabIndex = 11;
            this.picSymbolColor.TabStop = false;
            this.picSymbolColor.Click += new System.EventHandler(this.picSymbolColor_Click);
            // 
            // picLineColor
            // 
            this.picLineColor.BackColor = System.Drawing.Color.Black;
            this.picLineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLineColor.Location = new System.Drawing.Point(101, 110);
            this.picLineColor.Name = "picLineColor";
            this.picLineColor.Size = new System.Drawing.Size(55, 21);
            this.picLineColor.TabIndex = 10;
            this.picLineColor.TabStop = false;
            this.picLineColor.Click += new System.EventHandler(this.picLineColor_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Symbol Color:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Outline Color:";
            // 
            // nudSymbolSize
            // 
            this.nudSymbolSize.DecimalPlaces = 1;
            this.nudSymbolSize.Location = new System.Drawing.Point(102, 22);
            this.nudSymbolSize.Name = "nudSymbolSize";
            this.nudSymbolSize.Size = new System.Drawing.Size(55, 20);
            this.nudSymbolSize.TabIndex = 2;
            this.nudSymbolSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Min Symbol Size: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(105, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(15, 227);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 107;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "New Layer Name:";
            // 
            // txtNewLayer
            // 
            this.txtNewLayer.Enabled = false;
            this.txtNewLayer.Location = new System.Drawing.Point(16, 185);
            this.txtNewLayer.Name = "txtNewLayer";
            this.txtNewLayer.Size = new System.Drawing.Size(164, 20);
            this.txtNewLayer.TabIndex = 105;
            // 
            // chkNewLayer
            // 
            this.chkNewLayer.AutoSize = true;
            this.chkNewLayer.Location = new System.Drawing.Point(15, 144);
            this.chkNewLayer.Name = "chkNewLayer";
            this.chkNewLayer.Size = new System.Drawing.Size(111, 17);
            this.chkNewLayer.TabIndex = 104;
            this.chkNewLayer.Text = "Create New Layer";
            this.chkNewLayer.UseVisualStyleBackColor = true;
            this.chkNewLayer.CheckedChanged += new System.EventHandler(this.chkNewLayer_CheckedChanged);
            // 
            // cboUField
            // 
            this.cboUField.FormattingEnabled = true;
            this.cboUField.Location = new System.Drawing.Point(15, 106);
            this.cboUField.Name = "cboUField";
            this.cboUField.Size = new System.Drawing.Size(164, 21);
            this.cboUField.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Uncertainty Field:";
            // 
            // cboValueField
            // 
            this.cboValueField.FormattingEnabled = true;
            this.cboValueField.Location = new System.Drawing.Point(15, 66);
            this.cboValueField.Name = "cboValueField";
            this.cboValueField.Size = new System.Drawing.Size(164, 21);
            this.cboValueField.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Value Field:";
            // 
            // cboSourceLayer
            // 
            this.cboSourceLayer.FormattingEnabled = true;
            this.cboSourceLayer.Location = new System.Drawing.Point(16, 26);
            this.cboSourceLayer.Name = "cboSourceLayer";
            this.cboSourceLayer.Size = new System.Drawing.Size(164, 21);
            this.cboSourceLayer.TabIndex = 99;
            this.cboSourceLayer.SelectedIndexChanged += new System.EventHandler(this.cboSourceLayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Layer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMinVar);
            this.groupBox2.Controls.Add(this.lblMinValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboMethods);
            this.groupBox2.Location = new System.Drawing.Point(196, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 94);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uncertainty symbol";
            // 
            // nudMinVar
            // 
            this.nudMinVar.Location = new System.Drawing.Point(110, 65);
            this.nudMinVar.Name = "nudMinVar";
            this.nudMinVar.Size = new System.Drawing.Size(47, 20);
            this.nudMinVar.TabIndex = 19;
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(11, 68);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(78, 13);
            this.lblMinValue.TabIndex = 18;
            this.lblMinValue.Text = "Min Saturation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Visual variable:";
            // 
            // cboMethods
            // 
            this.cboMethods.FormattingEnabled = true;
            this.cboMethods.Items.AddRange(new object[] {
            "Saturation",
            "Color Value"});
            this.cboMethods.Location = new System.Drawing.Point(14, 38);
            this.cboMethods.Name = "cboMethods";
            this.cboMethods.Size = new System.Drawing.Size(142, 21);
            this.cboMethods.TabIndex = 16;
            this.cboMethods.Text = "Saturation";
            this.cboMethods.SelectedIndexChanged += new System.EventHandler(this.cboMethods_SelectedIndexChanged);
            // 
            // ColPropWin
            // 
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewLayer);
            this.Controls.Add(this.chkNewLayer);
            this.Controls.Add(this.cboUField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboValueField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSourceLayer);
            this.Controls.Add(this.label1);
            this.Name = "ColPropWin";
            this.Size = new System.Drawing.Size(377, 264);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinewidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSymbolColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbolSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudLinewidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSymbolColor;
        private System.Windows.Forms.PictureBox picLineColor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudSymbolSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewLayer;
        private System.Windows.Forms.CheckBox chkNewLayer;
        private System.Windows.Forms.ComboBox cboUField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboValueField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSourceLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMethods;
        private System.Windows.Forms.NumericUpDown nudMinVar;
        private System.Windows.Forms.Label lblMinValue;

    }
}
