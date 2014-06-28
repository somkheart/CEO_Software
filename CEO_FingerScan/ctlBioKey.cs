using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using CEO_FingerScan.DataModel;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace CEO_FingerScan
{
    public partial class ctlBioKey : UserControl
    {
        bool isConnected;
        public event PropertyChangedEventHandler property;
        public delegate void PropertyChangedEventHandler(string s);
        private bool flag = false;
        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public ctlBioKey()
        {
            InitializeComponent();
         }
        private void BtSave_Click(object sender, EventArgs e)
        {

        }
        private void ctlBioKey_Load(object sender, EventArgs e)
        {
            Init();
        }
        public void Init()
        {
            axZKFPEngX1.ImageWidth = 600;
            axZKFPEngX1.ImageHeight = 700;
            if (axZKFPEngX1.InitEngine() == 0)
            {
                isConnected = true;
                status.Text = "OK";
            }
            else
            {
                isConnected = false;
                status.Text = "NO";
            }
       
  
        }
        private void ZKFPEngX1_OnImageReceived(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent e)
        {
       
            String tmpFinger = "c:/finger.jpg";
            axZKFPEngX1.SaveJPG(tmpFinger);
            pictureBox.ImageLocation = tmpFinger;
        }

        private void axZKFPEngX1_OnFingerTouching(object sender, EventArgs e)
        {

        }

        private void axZKFPEngX1_OnImageReceived(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent e)
        {

            Flag = true;
            String FingerPic=Path.Combine("c:/","fingerPicture.jpg");
            String tmpSerial = axZKFPEngX1.SensorSN.ToString();
            pictureBox.ImageLocation = FingerPic;
            axZKFPEngX1.SaveJPG(FingerPic);
        }

        private void L1_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วโป้งซ้าย";
        }

        private void L2_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วชี้ซ้าย";
        }

        private void L3_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วกลางซ้าย";
        }

        private void L4_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วนางซ้าย";
        }

        private void L5_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วก้อยซ้าย";
        }

        private void R1_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วโป้งขวา";
        }

        private void R2_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วชี้ขวา";
        }

        private void R3_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วกลางขวา";
        }

        private void R4_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วนางขวา";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void saveFinger()
        {

           if (txtName.Text == "")
           {
               MessageBox.Show(" กรุณาระบุชื่อ-นามสกุล ");
               return; 

           }
           if (lbFinger.Text == "")
           {
               MessageBox.Show(" กรุณาเลือกนิ้ว ");
               return; 

           }
           if (Flag==false)
           {
               MessageBox.Show(" กรุณาสแกนนิ้ว ");
               return;

           }

            String defaultPath;
            StreamReader reader = new StreamReader("Setting.txt", true);
            String tmpObj = reader.ReadLine();
            Setting tmpSetting = JsonConvert.DeserializeObject<Setting>(tmpObj);
            defaultPath = tmpSetting.FolderPath;
            int widht = Convert.ToInt32(tmpSetting.Widht);
            int height = Convert.ToInt32(tmpSetting.Height);
            reader.Close();

           DialogResult result= MessageBox.Show("ยันยันการบันทึกข้อมูล", "ยืนยัน", MessageBoxButtons.OKCancel);
           if (result == DialogResult.OK)
           {
               String rootPath = defaultPath;
               String subPaht = Path.Combine("", txtName.Text);
               String FingPath = Path.Combine(rootPath, subPaht);
               Directory.CreateDirectory(FingPath);
               String tmpPath=Path.Combine(FingPath, txtName.Text + "-" + lbFinger.Text + ".jpg");
               axZKFPEngX1.SaveJPG(tmpPath);
 
           }
           pictureBox.Image = null;
           Flag = false;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //saveFinger();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            saveFinger();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lbFinger.Text = "นิ้วก้อยขวา";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
     
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.main0_r4_c3_f2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.main0_r4_c3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axZKFPEngX1_OnEnroll(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEvent e)
        {
           
        }

        private void axZKFPEngX1_OnFingerTouching_1(object sender, EventArgs e)
        {
           
        }

       

    }
}
