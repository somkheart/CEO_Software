namespace CEO_Config
{
    partial class Form1
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
            this.ตั้งค่าดาต้าเบส = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ตั้งค่าดาต้าเบส.SuspendLayout();
            this.SuspendLayout();
            // 
            // ตั้งค่าดาต้าเบส
            // 
            this.ตั้งค่าดาต้าเบส.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ตั้งค่าดาต้าเบส.Controls.Add(this.textBox3);
            this.ตั้งค่าดาต้าเบส.Controls.Add(this.label3);
            this.ตั้งค่าดาต้าเบส.Controls.Add(this.textBox2);
            this.ตั้งค่าดาต้าเบส.Controls.Add(this.label2);
            this.ตั้งค่าดาต้าเบส.Controls.Add(this.textBox1);
            this.ตั้งค่าดาต้าเบส.Controls.Add(this.label1);
            this.ตั้งค่าดาต้าเบส.Controls.Add(this.button1);
            this.ตั้งค่าดาต้าเบส.Location = new System.Drawing.Point(12, 12);
            this.ตั้งค่าดาต้าเบส.Name = "ตั้งค่าดาต้าเบส";
            this.ตั้งค่าดาต้าเบส.Size = new System.Drawing.Size(610, 240);
            this.ตั้งค่าดาต้าเบส.TabIndex = 0;
            this.ตั้งค่าดาต้าเบส.TabStop = false;
            this.ตั้งค่าดาต้าเบส.Text = "ตั้งค่าดาต้าเบส";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "USERNAME : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOST : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conntect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD  : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 257);
            this.Controls.Add(this.ตั้งค่าดาต้าเบส);
            this.Name = "Form1";
            this.Text = " :: ตั้งค่าดาต้าเบส  :: ";
            this.ตั้งค่าดาต้าเบส.ResumeLayout(false);
            this.ตั้งค่าดาต้าเบส.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ตั้งค่าดาต้าเบส;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

