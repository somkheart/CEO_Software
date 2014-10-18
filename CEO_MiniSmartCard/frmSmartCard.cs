using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CEO_Devices.SmartCard;
using System.IO;

namespace CEO_MiniSmartCard
{
    public partial class frmSmartCard : Form
    {
        public const String SoftwareCode="CEO_MINISMD";
        public const String SoftwareName = "CEO-SMARTCARD API 1.0";
        public frmSmartCard()
        {
            InitializeComponent();
        }
        public void check()
        {

            CEO_FingerLicense.CEO_Registry tmpRegistry = new CEO_FingerLicense.CEO_Registry();
            String tmpProductKey = CEO_FingerLicense.SoftwareKey.GetProductKey();
            String tmpSerialKey=tmpRegistry.GetSerialKey(SoftwareName);

            if (tmpRegistry.checkKey("INTERSITE", SoftwareCode, tmpSerialKey))
            {
                tmpRegistry.Write(SoftwareName, "INERSITE", tmpProductKey, tmpSerialKey);
                btDevice.Enabled = false;
            }
            else
            {
                btDevice.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            this.Hide();
        }
        private void Use_Notify()
        {
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.BalloonTipText = "โปรแกรมอ่านบัตรประชาชน";
            notifyIcon.BalloonTipTitle = "โปรแกรมอ่านบัตรประชาชน";
            notifyIcon.ShowBalloonTip(1);
            String[] deviceList=ctlSmardCard.getReaderList();
        }

        private void frmSmartCard_Load(object sender, EventArgs e)
        {
            Use_Notify();
            notifyIcon.Visible = true;
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
                check();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void เรมทำงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            startCheck.Checked = true;
            stopCheck.Checked = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ctlSmardCard.Config.loadPhoto = chkPicture.Checked;
            String info = ctlSmardCard.GetJsonSmartCardInfo();
            CEO_SmartCard smCard=ctlSmardCard.getSmartCardInfo();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("personinfo.txt", false))
            {
                if (chkPicture.Enabled)
                {
                    string path = Directory.GetCurrentDirectory();
                    if (smCard.Photo != null)
                    {
                        String tmpStr=Path.Combine(path, "person.jpg");
                        smCard.Photo.Save(tmpStr, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
                file.WriteLine(info);
            }

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            startCheck.Checked = false;
            stopCheck.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister regis = new frmRegister();
            regis.SoftwareCode = frmSmartCard.SoftwareCode;
            regis.SoftwareName = frmSmartCard.SoftwareName;
            regis.ShowDialog();
        }

        private void deviceChoice_Click(object sender, EventArgs e)
        {

        }
    }
}
