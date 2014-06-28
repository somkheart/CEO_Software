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
            CEO_Devices.SmartCard.CEO_Configurations ceO_Configurations1 = new CEO_Devices.SmartCard.CEO_Configurations();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textExport = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlSmartCard = new CEO_Devices.SmartCard.ctlSmardCardPanel();
            this.ctrlDevice = new CEO_Devices.SmartCard.ctlSmardCard();
            this.button3 = new System.Windows.Forms.Button();
            this.AutoFill = new System.Windows.Forms.TabPage();
            this.Setting = new System.Windows.Forms.TabPage();
            this.setting1 = new CEO_Configuration.Setting.Setting();
            this.Activate = new System.Windows.Forms.TabPage();
            this.lisense1 = new CEO_FingerLicense.Lisense();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบเราToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลงทะเบยนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ชวยเหลอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.textExport.SuspendLayout();
            this.Setting.SuspendLayout();
            this.Activate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.textExport);
            this.tabControl1.Controls.Add(this.AutoFill);
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
            this.textExport.Controls.Add(this.button4);
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
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(428, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "TXT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(582, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "EXCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(505, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "WORD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ctlSmartCard
            // 
            this.ctlSmartCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlSmartCard.Location = new System.Drawing.Point(44, 95);
            this.ctlSmartCard.Name = "ctlSmartCard";
            this.ctlSmartCard.Size = new System.Drawing.Size(625, 286);
            this.ctlSmartCard.TabIndex = 6;
            // 
            // ctrlDevice
            // 
            this.ctrlDevice.Config = ceO_Configurations1;
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
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AutoFill
            // 
            this.AutoFill.Location = new System.Drawing.Point(4, 22);
            this.AutoFill.Name = "AutoFill";
            this.AutoFill.Size = new System.Drawing.Size(713, 442);
            this.AutoFill.TabIndex = 3;
            this.AutoFill.Text = "ฟิลด์ฟอร์ม";
            this.AutoFill.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.setting1);
            this.Setting.Location = new System.Drawing.Point(4, 22);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(713, 442);
            this.Setting.TabIndex = 4;
            this.Setting.Text = "ตั้งค่า";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // setting1
            // 
            this.setting1.Location = new System.Drawing.Point(84, 42);
            this.setting1.Name = "setting1";
            this.setting1.Size = new System.Drawing.Size(490, 126);
            this.setting1.TabIndex = 0;
            this.setting1.Load += new System.EventHandler(this.setting1_Load);
            // 
            // Activate
            // 
            this.Activate.Controls.Add(this.lisense1);
            this.Activate.Location = new System.Drawing.Point(4, 22);
            this.Activate.Name = "Activate";
            this.Activate.Size = new System.Drawing.Size(713, 442);
            this.Activate.TabIndex = 5;
            this.Activate.Text = "ลงทะเบียน";
            this.Activate.UseVisualStyleBackColor = true;
            // 
            // lisense1
            // 
            this.lisense1.Location = new System.Drawing.Point(18, 22);
            this.lisense1.Name = "lisense1";
            this.lisense1.Size = new System.Drawing.Size(672, 411);
            this.lisense1.SoftwareCode = "INTER01";
            this.lisense1.TabIndex = 0;
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
            this.toolsToolStripMenuItem,
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
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // aboutusToolStripMenuItem
            // 
            this.aboutusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เกยวกบเราToolStripMenuItem,
            this.ลงทะเบยนToolStripMenuItem,
            this.ชวยเหลอToolStripMenuItem});
            this.aboutusToolStripMenuItem.Name = "aboutusToolStripMenuItem";
            this.aboutusToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aboutusToolStripMenuItem.Text = "About us";
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
            this.Activate.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage textExport;
        private System.Windows.Forms.TabPage AutoFill;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.TabPage Activate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutusToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private CEO_Devices.SmartCard.ctlSmardCard ctrlDevice;
        private CEO_Devices.SmartCard.ctlSmardCardPanel ctlSmartCard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private CEO_Configuration.Setting.Setting setting1;
        private CEO_FingerLicense.Lisense lisense1;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เกยวกบเราToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ชวยเหลอToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลงทะเบยนToolStripMenuItem;
    }
}

