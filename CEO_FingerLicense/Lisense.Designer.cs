namespace CEO_FingerLicense
{
    partial class Lisense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LicenseBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDealerID = new System.Windows.Forms.TextBox();
            this.LicenseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Activate Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LicenseBox
            // 
            this.LicenseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseBox.Controls.Add(this.label3);
            this.LicenseBox.Controls.Add(this.txtProductKey);
            this.LicenseBox.Controls.Add(this.txtSerialNumber);
            this.LicenseBox.Controls.Add(this.label1);
            this.LicenseBox.Controls.Add(this.label2);
            this.LicenseBox.Controls.Add(this.txtDealerID);
            this.LicenseBox.Controls.Add(this.button2);
            this.LicenseBox.Controls.Add(this.button1);
            this.LicenseBox.Location = new System.Drawing.Point(14, 10);
            this.LicenseBox.Name = "LicenseBox";
            this.LicenseBox.Size = new System.Drawing.Size(360, 198);
            this.LicenseBox.TabIndex = 4;
            this.LicenseBox.TabStop = false;
            this.LicenseBox.Text = "CEO Version 10.0";
            this.LicenseBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Key";
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(113, 41);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.ReadOnly = true;
            this.txtProductKey.Size = new System.Drawing.Size(156, 20);
            this.txtProductKey.TabIndex = 8;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(113, 114);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(156, 20);
            this.txtSerialNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial Number";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dealer ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDealerID
            // 
            this.txtDealerID.Location = new System.Drawing.Point(113, 77);
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(156, 20);
            this.txtDealerID.TabIndex = 4;
            // 
            // Lisense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LicenseBox);
            this.Name = "Lisense";
            this.Size = new System.Drawing.Size(390, 211);
            this.Load += new System.EventHandler(this.Lisense_Load);
            this.LicenseBox.ResumeLayout(false);
            this.LicenseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox LicenseBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDealerID;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductKey;
    }
}
