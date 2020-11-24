namespace R2Gate_Report_v2._0
{
    partial class GuideForm3
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
            this.pinSizeDLBox = new System.Windows.Forms.ComboBox();
            this.pinToothNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pinSizeDLBox
            // 
            this.pinSizeDLBox.FormattingEnabled = true;
            this.pinSizeDLBox.Items.AddRange(new object[] {
            "-",
            "D2.0     15",
            "D2.0     18",
            "D2.0     20"});
            this.pinSizeDLBox.Location = new System.Drawing.Point(131, 50);
            this.pinSizeDLBox.Name = "pinSizeDLBox";
            this.pinSizeDLBox.Size = new System.Drawing.Size(121, 21);
            this.pinSizeDLBox.TabIndex = 41;
            this.pinSizeDLBox.Text = "-";
            this.pinSizeDLBox.SelectedIndexChanged += new System.EventHandler(this.pinSizeDLBox_SelectedIndexChanged);
            // 
            // pinToothNumberBox
            // 
            this.pinToothNumberBox.Location = new System.Drawing.Point(131, 20);
            this.pinToothNumberBox.Name = "pinToothNumberBox";
            this.pinToothNumberBox.Size = new System.Drawing.Size(121, 20);
            this.pinToothNumberBox.TabIndex = 40;
            this.pinToothNumberBox.TextChanged += new System.EventHandler(this.pinToothNumberBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "• Tooth Number:";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "• SIZE( D x L ):";
            // 
            // GuideForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::R2Gate_Report_v2._0.Properties.Resources.Backgrond_DataPacientFormular;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(286, 90);
            this.Controls.Add(this.pinSizeDLBox);
            this.Controls.Add(this.pinToothNumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuideForm3";
            this.Text = "GuideForm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pinSizeDLBox;
        private System.Windows.Forms.TextBox pinToothNumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}