namespace CEO_FingerScan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.settingBox = new System.Windows.Forms.PictureBox();
            this.ctlBioKey1 = new CEO_FingerScan.ctlBioKey();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::CEO_FingerScan.Properties.Resources.main0_r2_c5;
            this.pictureBox4.Location = new System.Drawing.Point(667, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 87;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // settingBox
            // 
            this.settingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBox.Image = global::CEO_FingerScan.Properties.Resources.main0_r2_c2;
            this.settingBox.Location = new System.Drawing.Point(583, 28);
            this.settingBox.Name = "settingBox";
            this.settingBox.Size = new System.Drawing.Size(66, 67);
            this.settingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingBox.TabIndex = 86;
            this.settingBox.TabStop = false;
            this.settingBox.Click += new System.EventHandler(this.pictureBox3_Click);
            this.settingBox.MouseLeave += new System.EventHandler(this.settingBox_MouseLeave);
            this.settingBox.MouseHover += new System.EventHandler(this.settingBox_MouseHover);
            // 
            // ctlBioKey1
            // 
            this.ctlBioKey1.BackColor = System.Drawing.Color.Transparent;
            this.ctlBioKey1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctlBioKey1.BackgroundImage")));
            this.ctlBioKey1.Flag = false;
            this.ctlBioKey1.Location = new System.Drawing.Point(0, 0);
            this.ctlBioKey1.Name = "ctlBioKey1";
            this.ctlBioKey1.Size = new System.Drawing.Size(790, 476);
            this.ctlBioKey1.TabIndex = 88;
            this.ctlBioKey1.Load += new System.EventHandler(this.ctlBioKey1_Load_3);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 476);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.settingBox);
            this.Controls.Add(this.ctlBioKey1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมสแกนลายภาพนิ้วมือ ( CEO-FCM V2.0 ) - บริษัท พีเอ็ม อินเตอร์ฟู้ด กรุ๊ป จำกั" +
                "ด";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox settingBox;
        private ctlBioKey ctlBioKey1;

    }
}

