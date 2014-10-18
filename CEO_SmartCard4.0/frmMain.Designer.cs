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
            this.components = new System.ComponentModel.Container();
            CEO_Devices.SmartCard.CEO_Configurations ceO_Configurations2 = new CEO_Devices.SmartCard.CEO_Configurations();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textExport = new System.Windows.Forms.TabPage();
            this.btManual = new System.Windows.Forms.Button();
            this.btAuto = new System.Windows.Forms.Button();
            this.txtExcel = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.Button();
            this.ctlSmartCard = new CEO_Devices.SmartCard.ctlSmardCardPanel();
            this.ctrlDevice = new CEO_Devices.SmartCard.ctlSmardCard();
            this.button3 = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.chkPicture = new System.Windows.Forms.CheckBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.AppenFile = new System.Windows.Forms.RadioButton();
            this.overWrite = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลงทะเบยนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ชวยเหลอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.textExport.SuspendLayout();
            this.Setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MainContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.textExport);
            this.tabControl1.Controls.Add(this.Setting);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // textExport
            // 
            this.textExport.Controls.Add(this.btManual);
            this.textExport.Controls.Add(this.btAuto);
            this.textExport.Controls.Add(this.txtExcel);
            this.textExport.Controls.Add(this.txtWord);
            this.textExport.Controls.Add(this.txtText);
            this.textExport.Controls.Add(this.ctlSmartCard);
            this.textExport.Controls.Add(this.ctrlDevice);
            this.textExport.Controls.Add(this.button3);
            this.textExport.Location = new System.Drawing.Point(4, 22);
            this.textExport.Name = "textExport";
            this.textExport.Padding = new System.Windows.Forms.Padding(3);
            this.textExport.Size = new System.Drawing.Size(713, 429);
            this.textExport.TabIndex = 0;
            this.textExport.Text = "อ่านบัตรประชาชน";
            this.textExport.UseVisualStyleBackColor = true;
            this.textExport.Click += new System.EventHandler(this.textExport_Click);
            // 
            // btManual
            // 
            this.btManual.Location = new System.Drawing.Point(581, 54);
            this.btManual.Name = "btManual";
            this.btManual.Size = new System.Drawing.Size(75, 23);
            this.btManual.TabIndex = 11;
            this.btManual.Text = "Manual";
            this.btManual.UseVisualStyleBackColor = true;
            this.btManual.Click += new System.EventHandler(this.btManual_Click);
            // 
            // btAuto
            // 
            this.btAuto.Location = new System.Drawing.Point(503, 54);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(75, 23);
            this.btAuto.TabIndex = 10;
            this.btAuto.Text = "Auto";
            this.btAuto.UseVisualStyleBackColor = true;
            this.btAuto.Click += new System.EventHandler(this.btAuto_Click);
            // 
            // txtExcel
            // 
            this.txtExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcel.Location = new System.Drawing.Point(581, 83);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(75, 23);
            this.txtExcel.TabIndex = 9;
            this.txtExcel.Text = "EXCEL";
            this.txtExcel.UseVisualStyleBackColor = true;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Location = new System.Drawing.Point(503, 83);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(75, 23);
            this.txtWord.TabIndex = 8;
            this.txtWord.Text = "WORD";
            this.txtWord.UseVisualStyleBackColor = true;
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(426, 83);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(75, 23);
            this.txtText.TabIndex = 7;
            this.txtText.Text = "TXT";
            this.txtText.UseVisualStyleBackColor = true;
            // 
            // ctlSmartCard
            // 
            this.ctlSmartCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlSmartCard.Location = new System.Drawing.Point(44, 97);
            this.ctlSmartCard.Name = "ctlSmartCard";
            this.ctlSmartCard.Size = new System.Drawing.Size(625, 278);
            this.ctlSmartCard.TabIndex = 6;
            // 
            // ctrlDevice
            // 
            this.ctrlDevice.Config = ceO_Configurations2;
            this.ctrlDevice.Location = new System.Drawing.Point(56, 24);
            this.ctrlDevice.Name = "ctrlDevice";
            this.ctrlDevice.Size = new System.Drawing.Size(326, 33);
            this.ctrlDevice.SmartCard = null;
            this.ctrlDevice.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "เลือก";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.button2);
            this.Setting.Controls.Add(this.button1);
            this.Setting.Controls.Add(this.groupBox1);
            this.Setting.Location = new System.Drawing.Point(4, 22);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(713, 429);
            this.Setting.TabIndex = 4;
            this.Setting.Text = "ตั้งค่า";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "บักทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkData);
            this.groupBox1.Controls.Add(this.chkPicture);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.AppenFile);
            this.groupBox1.Controls.Add(this.overWrite);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ตั้งค่า";
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Checked = true;
            this.chkData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkData.Location = new System.Drawing.Point(217, 97);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(51, 17);
            this.chkData.TabIndex = 6;
            this.chkData.Text = "ข้อมูล";
            this.chkData.UseVisualStyleBackColor = true;
            // 
            // chkPicture
            // 
            this.chkPicture.AutoSize = true;
            this.chkPicture.Checked = true;
            this.chkPicture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPicture.Location = new System.Drawing.Point(90, 97);
            this.chkPicture.Name = "chkPicture";
            this.chkPicture.Size = new System.Drawing.Size(59, 17);
            this.chkPicture.TabIndex = 5;
            this.chkPicture.Text = "รูปภาพ";
            this.chkPicture.UseVisualStyleBackColor = true;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(141, 146);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(236, 20);
            this.txtFile.TabIndex = 4;
            // 
            // AppenFile
            // 
            this.AppenFile.AutoSize = true;
            this.AppenFile.Location = new System.Drawing.Point(217, 53);
            this.AppenFile.Name = "AppenFile";
            this.AppenFile.Size = new System.Drawing.Size(94, 17);
            this.AppenFile.TabIndex = 3;
            this.AppenFile.Text = "บันทึกไฟล์ใหม่";
            this.AppenFile.UseVisualStyleBackColor = true;
            // 
            // overWrite
            // 
            this.overWrite.AutoSize = true;
            this.overWrite.Checked = true;
            this.overWrite.Location = new System.Drawing.Point(90, 53);
            this.overWrite.Name = "overWrite";
            this.overWrite.Size = new System.Drawing.Size(107, 17);
            this.overWrite.TabIndex = 2;
            this.overWrite.TabStop = true;
            this.overWrite.Text = "บันทึกทับไฟล์เดิม";
            this.overWrite.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "เลือก";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutusToolStripMenuItem
            // 
            this.aboutusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ลงทะเบยนToolStripMenuItem,
            this.ชวยเหลอToolStripMenuItem});
            this.aboutusToolStripMenuItem.Name = "aboutusToolStripMenuItem";
            this.aboutusToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutusToolStripMenuItem.Text = "Help";
            this.aboutusToolStripMenuItem.Click += new System.EventHandler(this.aboutusToolStripMenuItem_Click);
            // 
            // ลงทะเบยนToolStripMenuItem
            // 
            this.ลงทะเบยนToolStripMenuItem.Name = "ลงทะเบยนToolStripMenuItem";
            this.ลงทะเบยนToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ลงทะเบยนToolStripMenuItem.Text = "ลงทะเบียน";
            this.ลงทะเบยนToolStripMenuItem.Click += new System.EventHandler(this.ลงทะเบยนToolStripMenuItem_Click);
            // 
            // ชวยเหลอToolStripMenuItem
            // 
            this.ชวยเหลอToolStripMenuItem.Name = "ชวยเหลอToolStripMenuItem";
            this.ชวยเหลอToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ชวยเหลอToolStripMenuItem.Text = "ช่วยเหลือ";
            this.ชวยเหลอToolStripMenuItem.Click += new System.EventHandler(this.ชวยเหลอToolStripMenuItem_Click);
            // 
            // Notify
            // 
            this.Notify.Text = "notifyIcon1";
            this.Notify.Visible = true;
            this.Notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseDoubleClick);
            // 
            // MainContext
            // 
            this.MainContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MainContext.Name = "MainContext";
            this.MainContext.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tabControl1.ResumeLayout(false);
            this.textExport.ResumeLayout(false);
            this.Setting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage textExport;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutusToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private CEO_Devices.SmartCard.ctlSmardCard ctrlDevice;
        private CEO_Devices.SmartCard.ctlSmardCardPanel ctlSmartCard;
        private System.Windows.Forms.ToolStripMenuItem ชวยเหลอToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลงทะเบยนToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.CheckBox chkPicture;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.RadioButton AppenFile;
        private System.Windows.Forms.RadioButton overWrite;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtText;
        private System.Windows.Forms.Button txtExcel;
        private System.Windows.Forms.Button txtWord;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip MainContext;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btManual;
        private System.Windows.Forms.Button btAuto;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}

