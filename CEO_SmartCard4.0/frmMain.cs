using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using CEO_Devices.SmartCard;
using System.Reflection;
using System.IO;
using CEO_Utils.OfficeTools;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using CEO_FingerLicense; 
namespace CEO_SmartCard4._0
{
    public partial class frmMain : Form
    {
        private CEO_Configurations config = new CEO_Configurations();
        private CEO_WinPCSC reader;
        private String SoftwareName;
        private frmRegis register;
        private frmAboutus about;
        public frmMain()
        {
            InitializeComponent();
            register = new frmRegis();
            reader = new CEO_WinPCSC();
            SoftwareName = "CEO-SmartCard 1.0";
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Notify.ContextMenuStrip = MainContext;
          //  Notify.ShowBalloonTip(1);

            btAuto.Enabled = true;
            btManual.Enabled = false;
            disAbleButton();

            loadInit();
        }
        private void loadInit()
        {
            Setting setting = new Setting();
            SettingInfo info = setting.ReadSetting<SettingInfo>();
            overWrite.Checked = info.overwrite;
            AppenFile.Checked = !info.overwrite;
            chkPicture.Checked = info.picture;
            chkData.Checked = info.info;
            txtFile.Text = info.ImagePath;

        }
        private void disAbleButton()
        {
            txtText.Enabled = false;
            txtWord.Enabled = false;
            txtExcel.Enabled = false;
        }
        private void EnableButton()
        {
            txtText.Enabled = true;
            txtWord.Enabled = true;
            txtExcel.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                System.Windows.Forms.MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void textExport_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            String SoftwareCode = "INTERSITE";
            bool check = SoftwareKey.checkRegistedKey(SoftwareCode);
            if (check)
            {
                ctrlDevice.Config.loadPhoto = true;
                ctlSmartCard.SetValue(ctrlDevice.getSmartCardInfo());
                txtText.Enabled = true;
                txtWord.Enabled = true;
                txtExcel.Enabled= true;
            }
            else
            {
                MessageBox.Show(" กรุณาทำการลงทะเบียน ");
            }
        }
        private void ctlSmardCard1_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            MirosoftWord.CreateWordProfile(ctrlDevice.getSmartCardInfo(), @"D:\\JobApplication.doc", "D:\\JobApplication_10.doc");
            System.Diagnostics.Process.Start(@"D:\\JobApplication_10.doc");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tmpFileName;
            tmpFileName = ctrlDevice.getSmartCardInfo().NationalID;
            TextWriter tw = new StreamWriter("c://" + tmpFileName + ".txt");
            tw.WriteLine(ctrlDevice.GetJsonSmartCardInfo());
            tw.Close();
        }
        private void setting1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void aboutusToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ลงทะเบยนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (register.IsDisposed)
            {
                register = new frmRegis();    
            }
            else
            {
                register.ShowDialog();
            }
        }
        private void เกยวกบเราToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void addForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Show();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void Notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ชวยเหลอToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notify.Dispose();
        }

        private void btManual_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btAuto.Enabled = true;
            btManual.Enabled = false;
            EnableButton();
        }

        private void btAuto_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            btAuto.Enabled = false;
            btManual.Enabled = true;
            disAbleButton();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           ctrlDevice.Config.loadPhoto = true;
           CEO_SmartCard smartcard= ctrlDevice.getSmartCardInfo();
           if (smartcard != null)
           {
               ctlSmartCard.SetValue(smartcard);
           }
           else
           {
               timer.Enabled = false;
           }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SettingInfo info = new SettingInfo();
            if (overWrite.Checked)
            {
                info.overwrite = true;
            }
            else
            {
                info.overwrite = false;
            }
            if (chkPicture.Checked)
            {
                info.picture = true;
            }
            else
            {
                info.picture = false;
            }
            if (chkData.Checked)
            {
                info.info = true;
            }
            else
            {
                info.info = false;
            }
            info.ImagePath = txtFile.Text;
            Setting setting = new Setting();
            setting.SaveSetting<SettingInfo>(info);
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           DialogResult result=folderDialog.ShowDialog();
           if (result == DialogResult.OK)
           {
               txtFile.Text=folderDialog.SelectedPath;
           }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
