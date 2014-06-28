namespace CEO_SmartCard4._0
{
    partial class frmRegis
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
            this.LicenseBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.Cancle = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.LicenseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LicenseBox
            // 
            this.LicenseBox.Controls.Add(this.label3);
            this.LicenseBox.Controls.Add(this.txtProductKey);
            this.LicenseBox.Controls.Add(this.txtSerialNumber);
            this.LicenseBox.Controls.Add(this.label1);
            this.LicenseBox.Controls.Add(this.label2);
            this.LicenseBox.Controls.Add(this.txtDealerID);
            this.LicenseBox.Controls.Add(this.Cancle);
            this.LicenseBox.Controls.Add(this.OK);
            this.LicenseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LicenseBox.Location = new System.Drawing.Point(0, 0);
            this.LicenseBox.Name = "LicenseBox";
            this.LicenseBox.Size = new System.Drawing.Size(485, 238);
            this.LicenseBox.TabIndex = 5;
            this.LicenseBox.TabStop = false;
            this.LicenseBox.Text = "CEO Version 10.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Key";
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(194, 62);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.ReadOnly = true;
            this.txtProductKey.Size = new System.Drawing.Size(156, 20);
            this.txtProductKey.TabIndex = 8;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerialNumber.Location = new System.Drawing.Point(194, 135);
            this.txtSerialNumber.MaxLength = 17;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(156, 20);
            this.txtSerialNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dealer ID";
            // 
            // txtDealerID
            // 
            this.txtDealerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDealerID.Location = new System.Drawing.Point(194, 98);
            this.txtDealerID.MaxLength = 30;
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(156, 20);
            this.txtDealerID.TabIndex = 4;
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(275, 172);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 3;
            this.Cancle.Text = "Cancle";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.button2_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(194, 172);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "Activate Code";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 238);
            this.Controls.Add(this.LicenseBox);
            this.Name = "frmRegis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegis";
            this.Load += new System.EventHandler(this.frmRegis_Load);
            this.LicenseBox.ResumeLayout(false);
            this.LicenseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LicenseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductKey;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.Button OK;
    }
}