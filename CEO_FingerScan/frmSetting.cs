using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CEO_FingerScan.DataModel;
using Newtonsoft.Json;
using System.IO;

namespace CEO_FingerScan
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader("Setting.txt", false);
                String tmpObj = reader.ReadLine();
                Setting tmpSetting = JsonConvert.DeserializeObject<Setting>(tmpObj);
                txtSetting.Text= tmpSetting.FolderPath;
                reader.Close();
            }
            catch
            {
                txtSetting.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                  txtSetting.Text = folderBrowserDialog1.SelectedPath;
            }

            //Setting tmpSetting = new Setting();
            //tmpSetting.FolderPath = txtSetting.Text;
            //String tmpObj = JsonConvert.SerializeObject(tmpSetting);
            //StreamWriter writer = new StreamWriter("Setting.txt", false);
            //writer.Write(tmpObj);
            //writer.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", txtSetting.Text);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = CEO_FingerScan.Properties.Resources.setting_r6_c2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Setting tmpSetting = new Setting();
            if (txtSetting.Text != "")
            {
 
                tmpSetting.FolderPath = txtSetting.Text;
              
            }
            String tmpObj = JsonConvert.SerializeObject(tmpSetting);
            StreamWriter writer = new StreamWriter("Setting.txt", false);
            writer.Write(tmpObj);
            writer.Close();
            this.Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = CEO_FingerScan.Properties.Resources.setting_r6_c2_f2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = CEO_FingerScan.Properties.Resources.setting_r6_c3;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox4.Image = CEO_FingerScan.Properties.Resources.setting_r6_c3_f2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = CEO_FingerScan.Properties.Resources.setting_r4_c4;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = CEO_FingerScan.Properties.Resources.setting_r4_c4_f2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = CEO_FingerScan.Properties.Resources.setting_r4_c6;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = CEO_FingerScan.Properties.Resources.setting_r4_c6_f2;
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
