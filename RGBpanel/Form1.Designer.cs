namespace RGBpanel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DownRightinfo = new System.Windows.Forms.Label();
            this.uploadsave = new System.Windows.Forms.PictureBox();
            this.uploadtemp = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.infobox = new System.Windows.Forms.Label();
            this.LoadCurrentSetting = new System.Windows.Forms.PictureBox();
            this.RGBmodebox = new System.Windows.Forms.ComboBox();
            this.colorchart = new System.Windows.Forms.PictureBox();
            this.speedset = new System.Windows.Forms.NumericUpDown();
            this.selectedicon = new System.Windows.Forms.PictureBox();
            this.minusbutton = new System.Windows.Forms.PictureBox();
            this.plusbutton = new System.Windows.Forms.PictureBox();
            this.RedDisplay = new System.Windows.Forms.Label();
            this.GreenDisplay = new System.Windows.Forms.Label();
            this.BlueDisplay = new System.Windows.Forms.Label();
            this.Color16Display = new System.Windows.Forms.TextBox();
            this.apply16 = new System.Windows.Forms.Label();
            this.hsbinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uploadsave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadtemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCurrentSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // DownRightinfo
            // 
            this.DownRightinfo.AutoSize = true;
            this.DownRightinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.DownRightinfo.Font = new System.Drawing.Font("宋体", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownRightinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DownRightinfo.Location = new System.Drawing.Point(868, 876);
            this.DownRightinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DownRightinfo.Name = "DownRightinfo";
            this.DownRightinfo.Size = new System.Drawing.Size(329, 20);
            this.DownRightinfo.TabIndex = 4;
            this.DownRightinfo.Text = "同照RGB控制软件 v1.0 作者：LTYXH";
            // 
            // uploadsave
            // 
            this.uploadsave.BackgroundImage = global::RGBpanel.Properties.Resources.上传并保存0;
            this.uploadsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadsave.Location = new System.Drawing.Point(48, 741);
            this.uploadsave.Name = "uploadsave";
            this.uploadsave.Size = new System.Drawing.Size(160, 80);
            this.uploadsave.TabIndex = 5;
            this.uploadsave.TabStop = false;
            this.uploadsave.Click += new System.EventHandler(this.Uploadsaveclick);
            // 
            // uploadtemp
            // 
            this.uploadtemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadtemp.BackgroundImage")));
            this.uploadtemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadtemp.Location = new System.Drawing.Point(48, 619);
            this.uploadtemp.Name = "uploadtemp";
            this.uploadtemp.Size = new System.Drawing.Size(160, 80);
            this.uploadtemp.TabIndex = 6;
            this.uploadtemp.TabStop = false;
            this.uploadtemp.Click += new System.EventHandler(this.Uploadtempclick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::RGBpanel.Properties.Resources.close;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1140, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 45);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.Closebuttonclick);
            // 
            // infobox
            // 
            this.infobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infobox.AutoSize = true;
            this.infobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.infobox.Font = new System.Drawing.Font("宋体", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infobox.ForeColor = System.Drawing.Color.White;
            this.infobox.Location = new System.Drawing.Point(1, 875);
            this.infobox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(89, 20);
            this.infobox.TabIndex = 8;
            this.infobox.Text = "欢迎使用";
            // 
            // LoadCurrentSetting
            // 
            this.LoadCurrentSetting.BackgroundImage = global::RGBpanel.Properties.Resources.加载当前设定0;
            this.LoadCurrentSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadCurrentSetting.Location = new System.Drawing.Point(48, 104);
            this.LoadCurrentSetting.Name = "LoadCurrentSetting";
            this.LoadCurrentSetting.Size = new System.Drawing.Size(160, 80);
            this.LoadCurrentSetting.TabIndex = 9;
            this.LoadCurrentSetting.TabStop = false;
            this.LoadCurrentSetting.Click += new System.EventHandler(this.LoadCurrentSettingClick);
            // 
            // RGBmodebox
            // 
            this.RGBmodebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.RGBmodebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RGBmodebox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGBmodebox.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RGBmodebox.ForeColor = System.Drawing.SystemColors.Window;
            this.RGBmodebox.FormattingEnabled = true;
            this.RGBmodebox.Items.AddRange(new object[] {
            "单色",
            "单色呼吸",
            "多色呼吸",
            "多色跑马",
            "彩虹跑马（默认颜色）",
            "#66CCFF",
            "关灯"});
            this.RGBmodebox.Location = new System.Drawing.Point(329, 239);
            this.RGBmodebox.Name = "RGBmodebox";
            this.RGBmodebox.Size = new System.Drawing.Size(231, 33);
            this.RGBmodebox.TabIndex = 12;
            this.RGBmodebox.SelectedIndexChanged += new System.EventHandler(this.RGBmodebox_SelectedIndexChanged);
            this.RGBmodebox.SelectionChangeCommitted += new System.EventHandler(this.Modechanged);
            // 
            // colorchart
            // 
            this.colorchart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorchart.BackgroundImage = global::RGBpanel.Properties.Resources.colorchartnew;
            this.colorchart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorchart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.colorchart.Location = new System.Drawing.Point(855, 570);
            this.colorchart.Name = "colorchart";
            this.colorchart.Size = new System.Drawing.Size(251, 251);
            this.colorchart.TabIndex = 13;
            this.colorchart.TabStop = false;
            this.colorchart.Click += new System.EventHandler(this.Colorchartclicked);
            // 
            // speedset
            // 
            this.speedset.BackColor = System.Drawing.SystemColors.InfoText;
            this.speedset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speedset.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speedset.ForeColor = System.Drawing.SystemColors.Window;
            this.speedset.Location = new System.Drawing.Point(694, 239);
            this.speedset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedset.Name = "speedset";
            this.speedset.ReadOnly = true;
            this.speedset.Size = new System.Drawing.Size(130, 32);
            this.speedset.TabIndex = 14;
            this.speedset.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.speedset.ValueChanged += new System.EventHandler(this.SpeedsetChanged);
            // 
            // selectedicon
            // 
            this.selectedicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectedicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectedicon.BackgroundImage")));
            this.selectedicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedicon.Location = new System.Drawing.Point(365, 490);
            this.selectedicon.Name = "selectedicon";
            this.selectedicon.Size = new System.Drawing.Size(120, 16);
            this.selectedicon.TabIndex = 15;
            this.selectedicon.TabStop = false;
            // 
            // minusbutton
            // 
            this.minusbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusbutton.BackgroundImage")));
            this.minusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusbutton.Location = new System.Drawing.Point(325, 425);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(30, 50);
            this.minusbutton.TabIndex = 16;
            this.minusbutton.TabStop = false;
            this.minusbutton.Click += new System.EventHandler(this.Minusbuttonclick);
            // 
            // plusbutton
            // 
            this.plusbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusbutton.BackgroundImage")));
            this.plusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusbutton.Location = new System.Drawing.Point(495, 425);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(30, 50);
            this.plusbutton.TabIndex = 17;
            this.plusbutton.TabStop = false;
            this.plusbutton.Click += new System.EventHandler(this.Plusbuttonclick);
            // 
            // RedDisplay
            // 
            this.RedDisplay.AutoSize = true;
            this.RedDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RedDisplay.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RedDisplay.Location = new System.Drawing.Point(577, 633);
            this.RedDisplay.Name = "RedDisplay";
            this.RedDisplay.Size = new System.Drawing.Size(90, 26);
            this.RedDisplay.TabIndex = 18;
            this.RedDisplay.Text = "label1";
            // 
            // GreenDisplay
            // 
            this.GreenDisplay.AutoSize = true;
            this.GreenDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GreenDisplay.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GreenDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GreenDisplay.Location = new System.Drawing.Point(577, 685);
            this.GreenDisplay.Name = "GreenDisplay";
            this.GreenDisplay.Size = new System.Drawing.Size(90, 26);
            this.GreenDisplay.TabIndex = 19;
            this.GreenDisplay.Text = "label1";
            // 
            // BlueDisplay
            // 
            this.BlueDisplay.AutoSize = true;
            this.BlueDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BlueDisplay.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlueDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlueDisplay.Location = new System.Drawing.Point(577, 736);
            this.BlueDisplay.Name = "BlueDisplay";
            this.BlueDisplay.Size = new System.Drawing.Size(90, 26);
            this.BlueDisplay.TabIndex = 20;
            this.BlueDisplay.Text = "label1";
            // 
            // Color16Display
            // 
            this.Color16Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Color16Display.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Color16Display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.Color16Display.Location = new System.Drawing.Point(579, 786);
            this.Color16Display.Name = "Color16Display";
            this.Color16Display.Size = new System.Drawing.Size(100, 36);
            this.Color16Display.TabIndex = 21;
            // 
            // apply16
            // 
            this.apply16.AutoSize = true;
            this.apply16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apply16.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.apply16.ForeColor = System.Drawing.Color.White;
            this.apply16.Location = new System.Drawing.Point(686, 792);
            this.apply16.Name = "apply16";
            this.apply16.Size = new System.Drawing.Size(64, 26);
            this.apply16.TabIndex = 22;
            this.apply16.Text = "确认";
            this.apply16.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // hsbinfo
            // 
            this.hsbinfo.AutoSize = true;
            this.hsbinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hsbinfo.Font = new System.Drawing.Font("宋体", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hsbinfo.ForeColor = System.Drawing.Color.White;
            this.hsbinfo.Location = new System.Drawing.Point(320, 673);
            this.hsbinfo.Name = "hsbinfo";
            this.hsbinfo.Size = new System.Drawing.Size(181, 26);
            this.hsbinfo.TabIndex = 23;
            this.hsbinfo.Text = "HSB功能开发中";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RGBpanel.Properties.Resources.background5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.hsbinfo);
            this.Controls.Add(this.apply16);
            this.Controls.Add(this.Color16Display);
            this.Controls.Add(this.BlueDisplay);
            this.Controls.Add(this.GreenDisplay);
            this.Controls.Add(this.RedDisplay);
            this.Controls.Add(this.plusbutton);
            this.Controls.Add(this.minusbutton);
            this.Controls.Add(this.selectedicon);
            this.Controls.Add(this.speedset);
            this.Controls.Add(this.colorchart);
            this.Controls.Add(this.RGBmodebox);
            this.Controls.Add(this.LoadCurrentSetting);
            this.Controls.Add(this.infobox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.uploadtemp);
            this.Controls.Add(this.uploadsave);
            this.Controls.Add(this.DownRightinfo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试用";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownatMain);
            ((System.ComponentModel.ISupportInitialize)(this.uploadsave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadtemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadCurrentSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DownRightinfo;
        private System.Windows.Forms.PictureBox uploadsave;
        private System.Windows.Forms.PictureBox uploadtemp;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label infobox;
        private System.Windows.Forms.PictureBox LoadCurrentSetting;
        private System.Windows.Forms.ComboBox RGBmodebox;
        private System.Windows.Forms.PictureBox colorchart;
        private System.Windows.Forms.NumericUpDown speedset;
        private System.Windows.Forms.PictureBox selectedicon;
        private System.Windows.Forms.PictureBox minusbutton;
        private System.Windows.Forms.PictureBox plusbutton;
        private System.Windows.Forms.Label RedDisplay;
        private System.Windows.Forms.Label GreenDisplay;
        private System.Windows.Forms.Label BlueDisplay;
        private System.Windows.Forms.TextBox Color16Display;
        private System.Windows.Forms.Label apply16;
        private System.Windows.Forms.Label hsbinfo;
    }
}

