namespace R2Gate_Report_v2._0
{
    partial class GuideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideForm));
            this.showHideSettings = new System.Windows.Forms.PictureBox();
            this.toothNotationBox = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.pin = new System.Windows.Forms.PictureBox();
            this.undo = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.implantSystemBox = new System.Windows.Forms.ComboBox();
            this.toothNotationLabel = new System.Windows.Forms.Label();
            this.implantSystemLabel = new System.Windows.Forms.Label();
            this.entityGuide = new System.Windows.Forms.Label();
            this.indexEntityOrTooth = new System.Windows.Forms.Label();
            this.guideTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showHideSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // showHideSettings
            // 
            this.showHideSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showHideSettings.BackgroundImage")));
            this.showHideSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showHideSettings.Location = new System.Drawing.Point(16, 156);
            this.showHideSettings.Name = "showHideSettings";
            this.showHideSettings.Size = new System.Drawing.Size(43, 26);
            this.showHideSettings.TabIndex = 44;
            this.showHideSettings.TabStop = false;
            this.showHideSettings.Click += new System.EventHandler(this.showHideSettings_Click);
            // 
            // toothNotationBox
            // 
            this.toothNotationBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.toothNotationBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toothNotationBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toothNotationBox.FormattingEnabled = true;
            this.toothNotationBox.Items.AddRange(new object[] {
            "None",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "18",
            "19",
            "20",
            "28",
            "29",
            "30"});
            this.toothNotationBox.Location = new System.Drawing.Point(35, 119);
            this.toothNotationBox.Name = "toothNotationBox";
            this.toothNotationBox.Size = new System.Drawing.Size(114, 21);
            this.toothNotationBox.TabIndex = 43;
            this.toothNotationBox.Text = "None";
            this.toothNotationBox.SelectedIndexChanged += new System.EventHandler(this.toothNotationBox_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Location = new System.Drawing.Point(18, 9);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(49, 27);
            this.save.TabIndex = 42;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.Transparent;
            this.pin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pin.BackgroundImage")));
            this.pin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pin.Location = new System.Drawing.Point(75, 9);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(45, 27);
            this.pin.TabIndex = 41;
            this.pin.TabStop = false;
            this.pin.Click += new System.EventHandler(this.pin_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.Transparent;
            this.undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undo.BackgroundImage")));
            this.undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undo.Location = new System.Drawing.Point(255, 9);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(34, 34);
            this.undo.TabIndex = 40;
            this.undo.TabStop = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.Location = new System.Drawing.Point(295, 13);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(34, 34);
            this.minimize.TabIndex = 39;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Location = new System.Drawing.Point(332, 11);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 25);
            this.exit.TabIndex = 38;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // implantSystemBox
            // 
            this.implantSystemBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.implantSystemBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.implantSystemBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.implantSystemBox.FormattingEnabled = true;
            this.implantSystemBox.Items.AddRange(new object[] {
            "Undecided",
            "AnyRidge",
            "AnyOne",
            "ST",
            "osstem_TS III",
            "Mini"});
            this.implantSystemBox.Location = new System.Drawing.Point(210, 120);
            this.implantSystemBox.Name = "implantSystemBox";
            this.implantSystemBox.Size = new System.Drawing.Size(121, 21);
            this.implantSystemBox.TabIndex = 37;
            this.implantSystemBox.Text = "Undecided";
            this.implantSystemBox.SelectedIndexChanged += new System.EventHandler(this.implantSystemBox_SelectedIndexChanged);
            // 
            // toothNotationLabel
            // 
            this.toothNotationLabel.AutoEllipsis = true;
            this.toothNotationLabel.AutoSize = true;
            this.toothNotationLabel.BackColor = System.Drawing.Color.Transparent;
            this.toothNotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toothNotationLabel.Location = new System.Drawing.Point(27, 93);
            this.toothNotationLabel.Name = "toothNotationLabel";
            this.toothNotationLabel.Size = new System.Drawing.Size(135, 24);
            this.toothNotationLabel.TabIndex = 35;
            this.toothNotationLabel.Text = "Tooth notation:";
            this.toothNotationLabel.Click += new System.EventHandler(this.toothNotation_Click);
            // 
            // implantSystemLabel
            // 
            this.implantSystemLabel.AutoEllipsis = true;
            this.implantSystemLabel.AutoSize = true;
            this.implantSystemLabel.BackColor = System.Drawing.Color.Transparent;
            this.implantSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.implantSystemLabel.Location = new System.Drawing.Point(203, 94);
            this.implantSystemLabel.Name = "implantSystemLabel";
            this.implantSystemLabel.Size = new System.Drawing.Size(141, 24);
            this.implantSystemLabel.TabIndex = 36;
            this.implantSystemLabel.Text = "Implant System:";
            // 
            // entityGuide
            // 
            this.entityGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entityGuide.BackColor = System.Drawing.Color.Transparent;
            this.entityGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityGuide.ForeColor = System.Drawing.Color.BlueViolet;
            this.entityGuide.Location = new System.Drawing.Point(75, 151);
            this.entityGuide.Name = "entityGuide";
            this.entityGuide.Size = new System.Drawing.Size(289, 37);
            this.entityGuide.TabIndex = 33;
            this.entityGuide.Text = "=> Transsection view";
            this.entityGuide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // indexEntityOrTooth
            // 
            this.indexEntityOrTooth.BackColor = System.Drawing.Color.Transparent;
            this.indexEntityOrTooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexEntityOrTooth.ForeColor = System.Drawing.Color.DarkRed;
            this.indexEntityOrTooth.Location = new System.Drawing.Point(52, 46);
            this.indexEntityOrTooth.Name = "indexEntityOrTooth";
            this.indexEntityOrTooth.Size = new System.Drawing.Size(267, 47);
            this.indexEntityOrTooth.TabIndex = 34;
            this.indexEntityOrTooth.Text = "Implant 1";
            this.indexEntityOrTooth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.indexEntityOrTooth.Click += new System.EventHandler(this.indexEntityOrTooth_Click);
            // 
            // guideTimer
            // 
            this.guideTimer.Enabled = true;
            this.guideTimer.Interval = 1;
            this.guideTimer.Tick += new System.EventHandler(this.guideTimer_Tick);
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 197);
            this.Controls.Add(this.showHideSettings);
            this.Controls.Add(this.toothNotationBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.implantSystemBox);
            this.Controls.Add(this.toothNotationLabel);
            this.Controls.Add(this.implantSystemLabel);
            this.Controls.Add(this.entityGuide);
            this.Controls.Add(this.indexEntityOrTooth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "GuideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GuideForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GuideForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GuideForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GuideForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GuideForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.showHideSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox showHideSettings;
        private System.Windows.Forms.ComboBox toothNotationBox;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox pin;
        private System.Windows.Forms.PictureBox undo;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.ComboBox implantSystemBox;
        private System.Windows.Forms.Label toothNotationLabel;
        private System.Windows.Forms.Label implantSystemLabel;
        private System.Windows.Forms.Label entityGuide;
        private System.Windows.Forms.Label indexEntityOrTooth;
        private System.Windows.Forms.Timer guideTimer;


    }
}