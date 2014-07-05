namespace CEO_SmartCard4._0
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
            CEO_Devices.SmartCard.CEO_Configurations ceO_Configurations5 = new CEO_Devices.SmartCard.CEO_Configurations();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textExport = new System.Windows.Forms.TabPage();
            this.ctlSmartCard = new CEO_Devices.SmartCard.ctlSmardCardPanel();
            this.ctrlDevice = new CEO_Devices.SmartCard.ctlSmardCard();
            this.button3 = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.TabPage();
            this.Activate = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบเราToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลงทะเบยนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ชวยเหลอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.textExport.SuspendLayout();
            this.Setting.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.textExport);
            this.tabControl1.Controls.Add(this.Setting);
            this.tabControl1.Controls.Add(this.Activate);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // textExport
            // 
            this.textExport.Controls.Add(this.button2);
            this.textExport.Controls.Add(this.button1);
            this.textExport.Controls.Add(this.ctlSmartCard);
            this.textExport.Controls.Add(this.ctrlDevice);
            this.textExport.Controls.Add(this.button3);
            this.textExport.Location = new System.Drawing.Point(4, 22);
            this.textExport.Name = "textExport";
            this.textExport.Padding = new System.Windows.Forms.Padding(3);
            this.textExport.Size = new System.Drawing.Size(713, 442);
            this.textExport.TabIndex = 0;
            this.textExport.Text = "อ่านบัตรประชาชน";
            this.textExport.UseVisualStyleBackColor = true;
            this.textExport.Click += new System.EventHandler(this.textExport_Click);
            // 
            // ctlSmartCard
            // 
            this.ctlSmartCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlSmartCard.Location = new System.Drawing.Point(44, 63);
            this.ctlSmartCard.Name = "ctlSmartCard";
            this.ctlSmartCard.Size = new System.Drawing.Size(625, 318);
            this.ctlSmartCard.TabIndex = 6;
            // 
            // ctrlDevice
            // 
            this.ctrlDevice.Config = ceO_Configurations5;
            this.ctrlDevice.Location = new System.Drawing.Point(56, 24);
            this.ctrlDevice.Name = "ctrlDevice";
            this.ctrlDevice.Size = new System.Drawing.Size(262, 33);
            this.ctrlDevice.SmartCard = null;
            this.ctrlDevice.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "เลือก";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.groupBox1);
            this.Setting.Location = new System.Drawing.Point(4, 22);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(713, 442);
            this.Setting.TabIndex = 4;
            this.Setting.Text = "ตั้งค่า";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // Activate
            // 
            this.Activate.Location = new System.Drawing.Point(4, 22);
            this.Activate.Name = "Activate";
            this.Activate.Size = new System.Drawing.Size(713, 442);
            this.Activate.TabIndex = 5;
            this.Activate.Text = "ลงทะเบียน";
            this.Activate.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(713, 442);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "เกี่ยวกับซอฟแวร์";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutusToolStripMenuItem
            // 
            this.aboutusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เกยวกบเราToolStripMenuItem,
            this.ลงทะเบยนToolStripMenuItem,
            this.ชวยเหลอToolStripMenuItem});
            this.aboutusToolStripMenuItem.Name = "aboutusToolStripMenuItem";
            this.aboutusToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutusToolStripMenuItem.Text = "Help";
            this.aboutusToolStripMenuItem.Click += new System.EventHandler(this.aboutusToolStripMenuItem_Click);
            // 
            // เกยวกบเราToolStripMenuItem
            // 
            this.เกยวกบเราToolStripMenuItem.Name = "เกยวกบเราToolStripMenuItem";
            this.เกยวกบเราToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.เกยวกบเราToolStripMenuItem.Text = "เกียวกับเรา";
            this.เกยวกบเราToolStripMenuItem.Click += new System.EventHandler(this.เกยวกบเราToolStripMenuItem_Click);
            // 
            // ลงทะเบยนToolStripMenuItem
            // 
            this.ลงทะเบยนToolStripMenuItem.Name = "ลงทะเบยนToolStripMenuItem";
            this.ลงทะเบยนToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ลงทะเบยนToolStripMenuItem.Text = "ลงทะเบียน";
            this.ลงทะเบยนToolStripMenuItem.Click += new System.EventHandler(this.ลงทะเบยนToolStripMenuItem_Click);
            // 
            // ชวยเหลอToolStripMenuItem
            // 
            this.ชวยเหลอToolStripMenuItem.Name = "ชวยเหลอToolStripMenuItem";
            this.ชวยเหลอToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ชวยเหลอToolStripMenuItem.Text = "ช่วยเหลือ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ตั้งค่า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "เลือก";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(90, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "บันทึกทับไฟล์เดิม";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(217, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "บันทึกไฟล์ใหม่";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "รูปภาพ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(217, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "ข้อมูล";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมบัตรประชาชน ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.textExport.ResumeLayout(false);
            this.Setting.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage textExport;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.TabPage Activate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutusToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private CEO_Devices.SmartCard.ctlSmardCard ctrlDevice;
        private CEO_Devices.SmartCard.ctlSmardCardPanel ctlSmartCard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem เกยวกบเราToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ชวยเหลอToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลงทะเบยนToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

