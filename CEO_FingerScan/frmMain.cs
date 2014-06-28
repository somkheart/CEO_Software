using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using CEO_FingerScan.DataModel;
using Newtonsoft.Json;

namespace CEO_FingerScan
{
    public partial class frmMain : Form
    {
        private frmSetting fs;
        private String fingerName;

        public String FingerName
        {
            get { return fingerName; }
            set { fingerName = value; }
        }

        public frmMain()
        {
            InitializeComponent();
            fs = new frmSetting();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ctlBioKey1.Init();
            try
            {
                StreamReader reader = new StreamReader("Setting.txt", false);
                String tmpObj = reader.ReadLine();
                Setting tmpSetting = JsonConvert.DeserializeObject<Setting>(tmpObj);
             //   txtPath.Text = tmpSetting.FolderPath;
                reader.Close();
            }
            catch
            {
            //    txtPath.Text = "";
            }

            
        }

        private void axZKFPEngX1_OnCapture(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEvent e)
           
        {
        
        }

        private void axZKFPEngX1_OnImageReceived(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent e)
        {
            string tmpImage;
            tmpImage = "c://fingerTmp.jpg";
        }

        private void axZKFPEngX1_OnFingerTouching(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

    
        }
        private void saveFinger()
        {

        }

        private void ctlBioKey1_Load(object sender, EventArgs e)
        {

        }

        private void ctlBioKey1_Load_1(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Setting tmpSetting = new Setting();
         //   tmpSetting.FolderPath = txtPath.Text;
            String tmpObj=JsonConvert.SerializeObject(tmpSetting);
            StreamWriter writer = new StreamWriter("Setting.txt", false);
            writer.Write(tmpObj);
            writer.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
             //   txtPath.Text = folderBrowserDialog1.SelectedPath;
            }


        }

        private void ctlBioKey1_Load_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            settingBox.BackgroundImage = Properties.Resources.main0_r2_c2_f2;
            if (fs.IsDisposed)
            {
                fs = new frmSetting();
                fs.Show();
            }
            else
            {
                fs.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
               DialogResult result= MessageBox.Show("ออกจากโปรแกรม", "ออกจากโปรแกรม", MessageBoxButtons.OKCancel);
               if (result == DialogResult.OK)
               {
                   this.Close();
               }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = CEO_FingerScan.Properties.Resources.main0_r2_c5_f2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = CEO_FingerScan.Properties.Resources.main0_r2_c5;
        }

        private void settingBox_MouseLeave(object sender, EventArgs e)
        {
            settingBox.Image = CEO_FingerScan.Properties.Resources.main0_r2_c2;
        }

        private void settingBox_MouseHover(object sender, EventArgs e)
        {
            settingBox.Image = CEO_FingerScan.Properties.Resources.main0_r2_c2_f2;
        }

        private void ctlBioKey1_Load_3(object sender, EventArgs e)
        {

        }

    }
}
