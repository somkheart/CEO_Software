namespace CEO_MiniSmartCard
{
    partial class frmSmartCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSmartCard));
            CEO_Devices.SmartCard.CEO_Configurations ceO_Configurations1 = new CEO_Devices.SmartCard.CEO_Configurations();
            this.btDevice = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chkPicture = new System.Windows.Forms.CheckBox();
            this.ctlSmardCard = new CEO_Devices.SmartCard.ctlSmardCard();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDevice
            // 
            this.btDevice.Location = new System.Drawing.Point(337, 23);
            this.btDevice.Name = "btDevice";
            this.btDevice.Size = new System.Drawing.Size(75, 25);
            this.btDevice.TabIndex = 2;
            this.btDevice.Text = "เลือกอุปกรณ์";
            this.btDevice.UseVisualStyleBackColor = true;
            this.btDevice.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startCheck,
            this.stopCheck,
            this.registerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 92);
            // 
            // startCheck
            // 
            this.startCheck.Name = "startCheck";
            this.startCheck.Size = new System.Drawing.Size(116, 22);
            this.startCheck.Text = "Start";
            this.startCheck.Click += new System.EventHandler(this.เรมทำงานToolStripMenuItem_Click);
            // 
            // stopCheck
            // 
            this.stopCheck.Name = "stopCheck";
            this.stopCheck.Size = new System.Drawing.Size(116, 22);
            this.stopCheck.Text = "Stop";
            this.stopCheck.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chkPicture
            // 
            this.chkPicture.AutoSize = true;
            this.chkPicture.Checked = true;
            this.chkPicture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPicture.Location = new System.Drawing.Point(99, 54);
            this.chkPicture.Name = "chkPicture";
            this.chkPicture.Size = new System.Drawing.Size(111, 17);
            this.chkPicture.TabIndex = 5;
            this.chkPicture.Text = "ดึงรูปภาพหน้าบัตร";
            this.chkPicture.UseVisualStyleBackColor = true;
            // 
            // ctlSmardCard
            // 
            this.ctlSmardCard.Config = ceO_Configurations1;
            this.ctlSmardCard.Location = new System.Drawing.Point(12, 23);
            this.ctlSmardCard.Name = "ctlSmardCard";
            this.ctlSmardCard.Size = new System.Drawing.Size(319, 25);
            this.ctlSmardCard.SmartCard = null;
            this.ctlSmardCard.TabIndex = 3;
            // 
            // frmSmartCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 79);
            this.Controls.Add(this.chkPicture);
            this.Controls.Add(this.ctlSmardCard);
            this.Controls.Add(this.btDevice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSmartCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมอ่านบัตรประชาชน";
            this.Load += new System.EventHandler(this.frmSmartCard_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDevice;
        private CEO_Devices.SmartCard.ctlSmardCard ctlSmardCard;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startCheck;
        private System.Windows.Forms.ToolStripMenuItem stopCheck;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox chkPicture;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
    }
}

