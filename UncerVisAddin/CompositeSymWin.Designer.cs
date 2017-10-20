namespace UncerVisAddin
{
    partial class CompositeSymWin
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
            this.tcUncer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudLinewidth = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.picSymbolColor = new System.Windows.Forms.PictureBox();
            this.picLineColor = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nudSymbolSize = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudThickness = new System.Windows.Forms.NumericUpDown();
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudChartSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudChartWidth = new System.Windows.Forms.NumericUpDown();
            this.nudConfidenceLevelCircle = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewLayer = new System.Windows.Forms.TextBox();
            this.chkNewLayer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboUField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboValueField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSourceLayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudConfidenceLevelBar = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tcUncer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinewidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSymbolColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbolSize)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidenceLevelCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidenceLevelBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUncer
            // 
            this.tcUncer.Controls.Add(this.tabPage1);
            this.tcUncer.Controls.Add(this.tabPage2);
            this.tcUncer.Location = new System.Drawing.Point(204, 12);
            this.tcUncer.Name = "tcUncer";
            this.tcUncer.SelectedIndex = 0;
            this.tcUncer.Size = new System.Drawing.Size(196, 226);
            this.tcUncer.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.nudLinewidth);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.nudConfidenceLevelCircle);
            this.tabPage1.Controls.Add(this.picSymbolColor);
            this.tabPage1.Controls.Add(this.picLineColor);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.nudSymbolSize);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(188, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Circles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudLinewidth
            // 
            this.nudLinewidth.DecimalPlaces = 1;
            this.nudLinewidth.Location = new System.Drawing.Point(118, 85);
            this.nudLinewidth.Name = "nudLinewidth";
            this.nudLinewidth.Size = new System.Drawing.Size(55, 20);
            this.nudLinewidth.TabIndex = 26;
            this.nudLinewidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Center line width: ";
            // 
            // picSymbolColor
            // 
            this.picSymbolColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.picSymbolColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSymbolColor.Location = new System.Drawing.Point(118, 45);
            this.picSymbolColor.Name = "picSymbolColor";
            this.picSymbolColor.Size = new System.Drawing.Size(55, 21);
            this.picSymbolColor.TabIndex = 24;
            this.picSymbolColor.TabStop = false;
            this.picSymbolColor.Click += new System.EventHandler(this.picSymbolColor_Click);
            // 
            // picLineColor
            // 
            this.picLineColor.BackColor = System.Drawing.Color.LightCoral;
            this.picLineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLineColor.Location = new System.Drawing.Point(118, 114);
            this.picLineColor.Name = "picLineColor";
            this.picLineColor.Size = new System.Drawing.Size(55, 21);
            this.picLineColor.TabIndex = 23;
            this.picLineColor.TabStop = false;
            this.picLineColor.Click += new System.EventHandler(this.picLineColor_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Symbol Color:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Center line color:";
            // 
            // nudSymbolSize
            // 
            this.nudSymbolSize.DecimalPlaces = 1;
            this.nudSymbolSize.Location = new System.Drawing.Point(118, 16);
            this.nudSymbolSize.Name = "nudSymbolSize";
            this.nudSymbolSize.Size = new System.Drawing.Size(55, 20);
            this.nudSymbolSize.TabIndex = 15;
            this.nudSymbolSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Min Symbol Size: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.nudConfidenceLevelBar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.nudChartSize);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.nudChartWidth);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(188, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nudThickness);
            this.groupBox1.Controls.Add(this.chk3D);
            this.groupBox1.Location = new System.Drawing.Point(9, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 71);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3D Chart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Thickness:";
            // 
            // nudThickness
            // 
            this.nudThickness.Enabled = false;
            this.nudThickness.Location = new System.Drawing.Point(102, 46);
            this.nudThickness.Name = "nudThickness";
            this.nudThickness.Size = new System.Drawing.Size(59, 20);
            this.nudThickness.TabIndex = 53;
            this.nudThickness.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Location = new System.Drawing.Point(9, 21);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(88, 17);
            this.chk3D.TabIndex = 50;
            this.chk3D.Text = "Display in 3D";
            this.chk3D.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Chart Size:";
            // 
            // nudChartSize
            // 
            this.nudChartSize.Location = new System.Drawing.Point(111, 41);
            this.nudChartSize.Name = "nudChartSize";
            this.nudChartSize.Size = new System.Drawing.Size(59, 20);
            this.nudChartSize.TabIndex = 53;
            this.nudChartSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Chart Width:";
            // 
            // nudChartWidth
            // 
            this.nudChartWidth.Location = new System.Drawing.Point(111, 11);
            this.nudChartWidth.Name = "nudChartWidth";
            this.nudChartWidth.Size = new System.Drawing.Size(59, 20);
            this.nudChartWidth.TabIndex = 51;
            this.nudChartWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudConfidenceLevelCircle
            // 
            this.nudConfidenceLevelCircle.Location = new System.Drawing.Point(117, 150);
            this.nudConfidenceLevelCircle.Name = "nudConfidenceLevelCircle";
            this.nudConfidenceLevelCircle.Size = new System.Drawing.Size(39, 20);
            this.nudConfidenceLevelCircle.TabIndex = 49;
            this.nudConfidenceLevelCircle.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(14, 215);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 47;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "New Layer Name:";
            // 
            // txtNewLayer
            // 
            this.txtNewLayer.Enabled = false;
            this.txtNewLayer.Location = new System.Drawing.Point(14, 185);
            this.txtNewLayer.Name = "txtNewLayer";
            this.txtNewLayer.Size = new System.Drawing.Size(164, 20);
            this.txtNewLayer.TabIndex = 45;
            // 
            // chkNewLayer
            // 
            this.chkNewLayer.AutoSize = true;
            this.chkNewLayer.Location = new System.Drawing.Point(15, 144);
            this.chkNewLayer.Name = "chkNewLayer";
            this.chkNewLayer.Size = new System.Drawing.Size(111, 17);
            this.chkNewLayer.TabIndex = 44;
            this.chkNewLayer.Text = "Create New Layer";
            this.chkNewLayer.UseVisualStyleBackColor = true;
            this.chkNewLayer.CheckedChanged += new System.EventHandler(this.chkNewLayer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Confidence Level:";
            // 
            // cboUField
            // 
            this.cboUField.FormattingEnabled = true;
            this.cboUField.Location = new System.Drawing.Point(14, 110);
            this.cboUField.Name = "cboUField";
            this.cboUField.Size = new System.Drawing.Size(164, 21);
            this.cboUField.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Uncertainty Field:";
            // 
            // cboValueField
            // 
            this.cboValueField.FormattingEnabled = true;
            this.cboValueField.Location = new System.Drawing.Point(14, 69);
            this.cboValueField.Name = "cboValueField";
            this.cboValueField.Size = new System.Drawing.Size(164, 21);
            this.cboValueField.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Value Field:";
            // 
            // cboSourceLayer
            // 
            this.cboSourceLayer.FormattingEnabled = true;
            this.cboSourceLayer.Location = new System.Drawing.Point(15, 28);
            this.cboSourceLayer.Name = "cboSourceLayer";
            this.cboSourceLayer.Size = new System.Drawing.Size(164, 21);
            this.cboSourceLayer.TabIndex = 38;
            this.cboSourceLayer.SelectedIndexChanged += new System.EventHandler(this.cboSourceLayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Layer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "%";
            // 
            // nudConfidenceLevelBar
            // 
            this.nudConfidenceLevelBar.Location = new System.Drawing.Point(111, 81);
            this.nudConfidenceLevelBar.Name = "nudConfidenceLevelBar";
            this.nudConfidenceLevelBar.Size = new System.Drawing.Size(39, 20);
            this.nudConfidenceLevelBar.TabIndex = 53;
            this.nudConfidenceLevelBar.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Confidence Level:";
            // 
            // CompositeSymWin
            // 
            this.Controls.Add(this.tcUncer);
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
            this.Name = "CompositeSymWin";
            this.Size = new System.Drawing.Size(417, 248);
            this.tcUncer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinewidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSymbolColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLineColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbolSize)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChartWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidenceLevelCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidenceLevelBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcUncer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudLinewidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picSymbolColor;
        private System.Windows.Forms.PictureBox picLineColor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nudSymbolSize;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudThickness;
        private System.Windows.Forms.CheckBox chk3D;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudChartSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudChartWidth;
        private System.Windows.Forms.NumericUpDown nudConfidenceLevelCircle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewLayer;
        private System.Windows.Forms.CheckBox chkNewLayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboValueField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSourceLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudConfidenceLevelBar;
        private System.Windows.Forms.Label label11;

    }
}
