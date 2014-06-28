namespace CEO_SmartCard4._0
{
    partial class frmRegister
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
            this.lisenseBox = new CEO_FingerLicense.Lisense();
            this.SuspendLayout();
            // 
            // lisenseBox
            // 
            this.lisenseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lisenseBox.Location = new System.Drawing.Point(0, 0);
            this.lisenseBox.Name = "lisenseBox";
            this.lisenseBox.Size = new System.Drawing.Size(1033, 579);
            this.lisenseBox.SoftwareCode = "INT001";
            this.lisenseBox.TabIndex = 0;
            this.lisenseBox.Load += new System.EventHandler(this.lisense1_Load);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 579);
            this.Controls.Add(this.lisenseBox);
            this.Name = "frmRegister";
            this.Text = "ลงทะเบียน";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.LocationChanged += new System.EventHandler(this.frmRegister_LocationChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private CEO_FingerLicense.Lisense lisenseBox;

   
    }
}