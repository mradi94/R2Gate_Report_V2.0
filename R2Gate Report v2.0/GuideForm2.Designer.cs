namespace R2Gate_Report_v2._0
{
    partial class GuideForm2
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
            this.gbrBox = new System.Windows.Forms.TextBox();
            this.BoneDensityBox = new System.Windows.Forms.ComboBox();
            this.sizeDLBox2 = new System.Windows.Forms.ComboBox();
            this.sizeDLBox1 = new System.Windows.Forms.ComboBox();
            this.gbrLabel = new System.Windows.Forms.Label();
            this.boneDensityLabel = new System.Windows.Forms.Label();
            this.sizeDLLabel = new System.Windows.Forms.Label();
            this.RecomendedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.narrowCrestDrillLabel = new System.Windows.Forms.Label();
            this.anchorStentLabel = new System.Windows.Forms.Label();
            this.muaLabel = new System.Windows.Forms.Label();
            this.boneProfilerCheckBox = new System.Windows.Forms.CheckBox();
            this.muaCheckBox = new System.Windows.Forms.CheckBox();
            this.anchorStentmuaCheckBox = new System.Windows.Forms.CheckBox();
            this.narrowCrestDrillmuaCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.dimensionMM = new System.Windows.Forms.TextBox();
            this.dimensionMMLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbrBox
            // 
            this.gbrBox.Location = new System.Drawing.Point(125, 66);
            this.gbrBox.Name = "gbrBox";
            this.gbrBox.Size = new System.Drawing.Size(161, 20);
            this.gbrBox.TabIndex = 49;
            this.gbrBox.TextChanged += new System.EventHandler(this.gbrBox_TextChanged);
            // 
            // BoneDensityBox
            // 
            this.BoneDensityBox.FormattingEnabled = true;
            this.BoneDensityBox.Items.AddRange(new object[] {
            "None",
            "D1",
            "D2",
            "D3",
            "D4"});
            this.BoneDensityBox.Location = new System.Drawing.Point(125, 44);
            this.BoneDensityBox.Name = "BoneDensityBox";
            this.BoneDensityBox.Size = new System.Drawing.Size(161, 21);
            this.BoneDensityBox.TabIndex = 48;
            this.BoneDensityBox.Text = "None";
            this.BoneDensityBox.SelectedIndexChanged += new System.EventHandler(this.BoneDensityBox_SelectedIndexChanged);
            // 
            // sizeDLBox2
            // 
            this.sizeDLBox2.FormattingEnabled = true;
            this.sizeDLBox2.Items.AddRange(new object[] {
            "-",
            "7",
            "8.5",
            "10",
            "11.5",
            "13",
            "15"});
            this.sizeDLBox2.Location = new System.Drawing.Point(208, 17);
            this.sizeDLBox2.Name = "sizeDLBox2";
            this.sizeDLBox2.Size = new System.Drawing.Size(79, 21);
            this.sizeDLBox2.TabIndex = 47;
            this.sizeDLBox2.Text = "-";
            this.sizeDLBox2.SelectedIndexChanged += new System.EventHandler(this.sizeDLBox2_SelectedIndexChanged);
            // 
            // sizeDLBox1
            // 
            this.sizeDLBox1.FormattingEnabled = true;
            this.sizeDLBox1.Items.AddRange(new object[] {
            "-",
            "D3.0",
            "D3.25",
            "D3.5",
            "D4.0",
            "D4.5",
            "D5.0",
            "D5.5",
            "D6.0",
            "D6.5",
            "D7.0",
            "D7.5",
            "D8.0"});
            this.sizeDLBox1.Location = new System.Drawing.Point(126, 17);
            this.sizeDLBox1.Name = "sizeDLBox1";
            this.sizeDLBox1.Size = new System.Drawing.Size(79, 21);
            this.sizeDLBox1.TabIndex = 46;
            this.sizeDLBox1.Text = "-";
            this.sizeDLBox1.SelectedIndexChanged += new System.EventHandler(this.sizeDLBox1_SelectedIndexChanged);
            // 
            // gbrLabel
            // 
            this.gbrLabel.AutoEllipsis = true;
            this.gbrLabel.AutoSize = true;
            this.gbrLabel.BackColor = System.Drawing.Color.Transparent;
            this.gbrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrLabel.Location = new System.Drawing.Point(27, 69);
            this.gbrLabel.Name = "gbrLabel";
            this.gbrLabel.Size = new System.Drawing.Size(44, 15);
            this.gbrLabel.TabIndex = 45;
            this.gbrLabel.Text = "• GBR:";
            // 
            // boneDensityLabel
            // 
            this.boneDensityLabel.AutoEllipsis = true;
            this.boneDensityLabel.AutoSize = true;
            this.boneDensityLabel.BackColor = System.Drawing.Color.Transparent;
            this.boneDensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boneDensityLabel.Location = new System.Drawing.Point(27, 47);
            this.boneDensityLabel.Name = "boneDensityLabel";
            this.boneDensityLabel.Size = new System.Drawing.Size(90, 15);
            this.boneDensityLabel.TabIndex = 44;
            this.boneDensityLabel.Text = "• Bone Density:";
            // 
            // sizeDLLabel
            // 
            this.sizeDLLabel.AutoEllipsis = true;
            this.sizeDLLabel.AutoSize = true;
            this.sizeDLLabel.BackColor = System.Drawing.Color.Transparent;
            this.sizeDLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeDLLabel.Location = new System.Drawing.Point(28, 17);
            this.sizeDLLabel.Name = "sizeDLLabel";
            this.sizeDLLabel.Size = new System.Drawing.Size(86, 15);
            this.sizeDLLabel.TabIndex = 43;
            this.sizeDLLabel.Text = "• SIZE( D x L ):";
            // 
            // RecomendedLabel
            // 
            this.RecomendedLabel.AutoEllipsis = true;
            this.RecomendedLabel.AutoSize = true;
            this.RecomendedLabel.BackColor = System.Drawing.Color.Transparent;
            this.RecomendedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecomendedLabel.Location = new System.Drawing.Point(28, 109);
            this.RecomendedLabel.Name = "RecomendedLabel";
            this.RecomendedLabel.Size = new System.Drawing.Size(96, 15);
            this.RecomendedLabel.TabIndex = 51;
            this.RecomendedLabel.Text = "• Recomended :";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Bone Profiler";
            // 
            // narrowCrestDrillLabel
            // 
            this.narrowCrestDrillLabel.AutoEllipsis = true;
            this.narrowCrestDrillLabel.AutoSize = true;
            this.narrowCrestDrillLabel.BackColor = System.Drawing.Color.Transparent;
            this.narrowCrestDrillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrowCrestDrillLabel.Location = new System.Drawing.Point(141, 132);
            this.narrowCrestDrillLabel.Name = "narrowCrestDrillLabel";
            this.narrowCrestDrillLabel.Size = new System.Drawing.Size(106, 15);
            this.narrowCrestDrillLabel.TabIndex = 53;
            this.narrowCrestDrillLabel.Text = "Narrow Crest Drill ";
            // 
            // anchorStentLabel
            // 
            this.anchorStentLabel.AutoEllipsis = true;
            this.anchorStentLabel.AutoSize = true;
            this.anchorStentLabel.BackColor = System.Drawing.Color.Transparent;
            this.anchorStentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchorStentLabel.Location = new System.Drawing.Point(138, 154);
            this.anchorStentLabel.Name = "anchorStentLabel";
            this.anchorStentLabel.Size = new System.Drawing.Size(82, 15);
            this.anchorStentLabel.TabIndex = 54;
            this.anchorStentLabel.Text = " Anchor Stent ";
            // 
            // muaLabel
            // 
            this.muaLabel.AutoEllipsis = true;
            this.muaLabel.AutoSize = true;
            this.muaLabel.BackColor = System.Drawing.Color.Transparent;
            this.muaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaLabel.Location = new System.Drawing.Point(141, 178);
            this.muaLabel.Name = "muaLabel";
            this.muaLabel.Size = new System.Drawing.Size(37, 15);
            this.muaLabel.TabIndex = 55;
            this.muaLabel.Text = "MUA:";
            this.muaLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // boneProfilerCheckBox
            // 
            this.boneProfilerCheckBox.AutoSize = true;
            this.boneProfilerCheckBox.Location = new System.Drawing.Point(127, 112);
            this.boneProfilerCheckBox.Name = "boneProfilerCheckBox";
            this.boneProfilerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.boneProfilerCheckBox.TabIndex = 56;
            this.boneProfilerCheckBox.UseVisualStyleBackColor = true;
            this.boneProfilerCheckBox.CheckedChanged += new System.EventHandler(this.boneProfilerCheckBox_CheckedChanged);
            // 
            // muaCheckBox
            // 
            this.muaCheckBox.AutoSize = true;
            this.muaCheckBox.Location = new System.Drawing.Point(127, 179);
            this.muaCheckBox.Name = "muaCheckBox";
            this.muaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.muaCheckBox.TabIndex = 57;
            this.muaCheckBox.UseVisualStyleBackColor = true;
            this.muaCheckBox.CheckedChanged += new System.EventHandler(this.muaCheckBox_CheckedChanged);
            // 
            // anchorStentmuaCheckBox
            // 
            this.anchorStentmuaCheckBox.AutoSize = true;
            this.anchorStentmuaCheckBox.Location = new System.Drawing.Point(127, 156);
            this.anchorStentmuaCheckBox.Name = "anchorStentmuaCheckBox";
            this.anchorStentmuaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.anchorStentmuaCheckBox.TabIndex = 58;
            this.anchorStentmuaCheckBox.UseVisualStyleBackColor = true;
            this.anchorStentmuaCheckBox.CheckedChanged += new System.EventHandler(this.anchorStentmuaCheckBox_CheckedChanged);
            // 
            // narrowCrestDrillmuaCheckBox
            // 
            this.narrowCrestDrillmuaCheckBox.AutoSize = true;
            this.narrowCrestDrillmuaCheckBox.Location = new System.Drawing.Point(127, 134);
            this.narrowCrestDrillmuaCheckBox.Name = "narrowCrestDrillmuaCheckBox";
            this.narrowCrestDrillmuaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.narrowCrestDrillmuaCheckBox.TabIndex = 59;
            this.narrowCrestDrillmuaCheckBox.UseVisualStyleBackColor = true;
            this.narrowCrestDrillmuaCheckBox.CheckedChanged += new System.EventHandler(this.narrowCrestDrillmuaCheckBox_CheckedChanged);
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.BackColor = System.Drawing.Color.Transparent;
            this.radioButton0.Enabled = false;
            this.radioButton0.Location = new System.Drawing.Point(185, 178);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(38, 17);
            this.radioButton0.TabIndex = 60;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = " 0°";
            this.radioButton0.UseVisualStyleBackColor = false;
            this.radioButton0.CheckedChanged += new System.EventHandler(this.radioButton0_CheckedChanged);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.BackColor = System.Drawing.Color.Transparent;
            this.radioButton17.Enabled = false;
            this.radioButton17.Location = new System.Drawing.Point(185, 197);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(41, 17);
            this.radioButton17.TabIndex = 61;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "17°";
            this.radioButton17.UseVisualStyleBackColor = false;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.BackColor = System.Drawing.Color.Transparent;
            this.radioButton29.Enabled = false;
            this.radioButton29.Location = new System.Drawing.Point(185, 216);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(41, 17);
            this.radioButton29.TabIndex = 62;
            this.radioButton29.TabStop = true;
            this.radioButton29.Text = "29°";
            this.radioButton29.UseVisualStyleBackColor = false;
            this.radioButton29.CheckedChanged += new System.EventHandler(this.radioButton29_CheckedChanged);
            // 
            // dimensionMM
            // 
            this.dimensionMM.BackColor = System.Drawing.Color.White;
            this.dimensionMM.Enabled = false;
            this.dimensionMM.Location = new System.Drawing.Point(243, 178);
            this.dimensionMM.Name = "dimensionMM";
            this.dimensionMM.Size = new System.Drawing.Size(34, 20);
            this.dimensionMM.TabIndex = 63;
            this.dimensionMM.TextChanged += new System.EventHandler(this.dimensionMM_TextChanged);
            // 
            // dimensionMMLabel
            // 
            this.dimensionMMLabel.AutoEllipsis = true;
            this.dimensionMMLabel.AutoSize = true;
            this.dimensionMMLabel.BackColor = System.Drawing.Color.Transparent;
            this.dimensionMMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionMMLabel.Location = new System.Drawing.Point(280, 180);
            this.dimensionMMLabel.Name = "dimensionMMLabel";
            this.dimensionMMLabel.Size = new System.Drawing.Size(29, 15);
            this.dimensionMMLabel.TabIndex = 64;
            this.dimensionMMLabel.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(225, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 65;
            this.label9.Text = "+";
            // 
            // GuideForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::R2Gate_Report_v2._0.Properties.Resources.Backgrond_DataPacientFormular;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 254);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dimensionMMLabel);
            this.Controls.Add(this.dimensionMM);
            this.Controls.Add(this.radioButton29);
            this.Controls.Add(this.radioButton17);
            this.Controls.Add(this.radioButton0);
            this.Controls.Add(this.narrowCrestDrillmuaCheckBox);
            this.Controls.Add(this.anchorStentmuaCheckBox);
            this.Controls.Add(this.muaCheckBox);
            this.Controls.Add(this.boneProfilerCheckBox);
            this.Controls.Add(this.muaLabel);
            this.Controls.Add(this.anchorStentLabel);
            this.Controls.Add(this.narrowCrestDrillLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RecomendedLabel);
            this.Controls.Add(this.gbrBox);
            this.Controls.Add(this.BoneDensityBox);
            this.Controls.Add(this.sizeDLBox2);
            this.Controls.Add(this.sizeDLBox1);
            this.Controls.Add(this.gbrLabel);
            this.Controls.Add(this.boneDensityLabel);
            this.Controls.Add(this.sizeDLLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuideForm2";
            this.Text = "GuideForm2";
            this.Load += new System.EventHandler(this.GuideForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gbrBox;
        private System.Windows.Forms.ComboBox BoneDensityBox;
        private System.Windows.Forms.ComboBox sizeDLBox2;
        private System.Windows.Forms.ComboBox sizeDLBox1;
        private System.Windows.Forms.Label gbrLabel;
        private System.Windows.Forms.Label boneDensityLabel;
        private System.Windows.Forms.Label sizeDLLabel;
        private System.Windows.Forms.Label RecomendedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label narrowCrestDrillLabel;
        private System.Windows.Forms.Label anchorStentLabel;
        private System.Windows.Forms.Label muaLabel;
        private System.Windows.Forms.CheckBox boneProfilerCheckBox;
        private System.Windows.Forms.CheckBox muaCheckBox;
        private System.Windows.Forms.CheckBox anchorStentmuaCheckBox;
        private System.Windows.Forms.CheckBox narrowCrestDrillmuaCheckBox;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton29;
        private System.Windows.Forms.TextBox dimensionMM;
        private System.Windows.Forms.Label dimensionMMLabel;
        private System.Windows.Forms.Label label9;
    }
}