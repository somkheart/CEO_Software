using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using CEO_FPM_V3._0_Standard.Model;
using CEO_FPM_V3._0_Standard.License;

namespace CEO_FPM_V3._0_Standard
{
    public partial class frmMain : Form
    {
        private String SoftwareCode;
        private bool flag = false;
        private bool isConnected;

        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }
        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public frmMain()
        {
            InitializeComponent();
            Init();
            checkSerial();
        }
        private bool checkSerial()
        {
            String SoftwareName;
            SoftwareName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            String tmpSerialKey = CEO_FingerLicense.License.GetProductSerialKey(SoftwareName);
            String tmpDeailderID = CEO_FingerLicense.License.GetProductDealerID(SoftwareName);
            if (CEO_FingerLicense.License.GetSerialKey(tmpDeailderID) == tmpSerialKey)
            {
                txtDealerID.Text = tmpDeailderID;
                txtDealerID.Enabled = false;
                txtSerialNumber.Text = tmpSerialKey;
                txtSerialNumber.Enabled = false;
                txtProductKey.Enabled = false;
                txtEditionText.Text = "Standard Edition";
                txtEdition2.Text = "Standard Edition";
                return true;
            }
            else
            {
                txtDealerID.Enabled = true;
                txtSerialNumber.Enabled = true;
                txtProductKey.Enabled = false;
                txtEditionText.Text = "Demo Version";
                txtEdition2.Text = "Demo Version";
                return false;
            }
        }
        public void Init()
        {
            LoadSetting();
            //axZKFPEngX1.ImageWidth = 600;
            //axZKFPEngX1.ImageHeight = 700;
            //if (axZKFPEngX1.InitEngine() == 0)
            //{
            //    isConnected = true;
            //}
            //else
            //{
            //    isConnected = false;
            //}
        }
        private void LoadSetting()
        {
            try
            {
                StreamReader reader = new StreamReader("Setting.txt", false);
                String tmpObj = reader.ReadLine();
                Setting tmpSetting = JsonConvert.DeserializeObject<Setting>(tmpObj);
                txtSetting.Text = tmpSetting.FolderPath;
                reader.Close();
            }
            catch
            {
                txtSetting.Text = "";
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            SoftwareCode = "SM001";
            txtProductKey.Text = CEO_FingerLicense.License.GetProductKey();
            //ceoFlash.Movie = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Flash", "Flash-CEO-Software.swf");
            //ceoFlash.Play();
            getRegisterKey();
        }
        private void getRegisterKey()
        {
            String SoftwareName;
            SoftwareName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            username.Text = CEO_FingerLicense.License.GetRegistryValue(SoftwareName, "username");
            password.Text = CEO_FingerLicense.License.GetRegistryValue(SoftwareName, "password");
            txtSetting.Text = CEO_FingerLicense.License.GetRegistryValue(SoftwareName, "FilePath");
            txtUserText.Text = username.Text;
        }
        private void FingerPrint_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Setting_Click(object sender, EventArgs e)
        {

        }

        private void ตั้งค่า_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlRegister1_Load(object sender, EventArgs e)
        {

        }

        private void R2_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วขี้ขวา";
        }

        private void L5_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วก้อยซ้าย";
        }

        private void L4_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วนางซ้าย";
        }

        private void L3_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วกลางซ้าย";
        }

        private void L2_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วชี้ซ้าย";
        }

        private void L1_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วโป้งซ้าย";
        }

        private void R1_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วโป้งขวา";
        }

        private void R3_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วกลางขวา";
        }

        private void R4_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วนางขวา";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            lbFingerText.Text = "นิ้วก้อยขวา";
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void saveFinger()
        {
           if (txtName.Text == "")
            {
                MessageBox.Show(" กรุณาระบุชื่อ-นามสกุล ");
                return;

            }
           if (lbFingerText.Text == "")
            {
                MessageBox.Show(" กรุณาเลือกนิ้ว ");
                return;

            }
            String defaultPath;
            int widht,height;

            try
            {
                StreamReader reader = new StreamReader("Setting.txt", true);
                String tmpObj = reader.ReadLine();
                Setting tmpSetting = JsonConvert.DeserializeObject<Setting>(tmpObj);
                defaultPath = tmpSetting.FolderPath;
                widht = Convert.ToInt32(tmpSetting.Widht);
                height = Convert.ToInt32(tmpSetting.Height);
                reader.Close();
            }
            catch
            {
                widht = 600;
                Height = 700;
                defaultPath = "c:";
            }
            DialogResult result = MessageBox.Show("ยันยันการบันทึกข้อมูล", "ยืนยัน", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                String rootPath = defaultPath;
                String subPaht = Path.Combine("", txtName.Text);
                String FingPath = Path.Combine(rootPath, subPaht);
                Directory.CreateDirectory(FingPath);
                String tmpPath = Path.Combine(FingPath, txtName.Text + "-" + lbFingerText.Text + ".jpg");
             //   axZKFPEngX1.SaveJPG(tmpPath);
            }
            fingerPicture.Image = null;
            Flag = false;

        }

        //private void axZKFPEngX1_OnCapture(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEvent e)
        //{
           
        //}

        //private void axZKFPEngX1_OnImageReceived(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent e)
        //{
        //    String tmpFinger = "c:/finger.jpg";
        //    axZKFPEngX1.SaveJPG(tmpFinger);
        //    fingerPicture.ImageLocation = tmpFinger;
        //}

        private void panel7_Click(object sender, EventArgs e)
        {
            saveFinger();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", txtSetting.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult tmpFolder=Folder.ShowDialog();
           if (tmpFolder == DialogResult.OK)
           {
              txtSetting.Text=Folder.SelectedPath;
           }
           Setting tmpSetting = new Setting();
           String tmpObj = JsonConvert.SerializeObject(tmpSetting);
           StreamWriter writer = new StreamWriter("Setting.txt", false);
           writer.Write(tmpObj);
           writer.Close();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
       

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setting tmpSetting = new Setting();
            tmpSetting.FolderPath = txtSetting.Text;
            tmpSetting.Widht = 600;
            tmpSetting.Height = 600;
            String tmpObj = JsonConvert.SerializeObject(tmpSetting);
            StreamWriter writer = new StreamWriter("Setting.txt", false);
            writer.Write(tmpObj);
            writer.Close();
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");

        }

        private void ctrlControlBar2_Load(object sender, EventArgs e)
        {

        }

        private void ctrlExportButton1_Load(object sender, EventArgs e)
        {
           
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            if (!ProductKey.isActived())
            {
                MessageBox.Show("Not Actived");
                //btExport.Enabled = false;
            }
            saveFinger();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (CEO_FingerLicense.License.GetSerialKey(txtProductKey.Text, txtDealerID.Text,this.SoftwareCode) == txtSerialNumber.Text)
            {
                CEO_FingerLicense.License.SaveRegisKey(System.Reflection.Assembly.GetEntryAssembly().GetName().Name,txtSerialNumber.Text, txtDealerID.Text);
                MessageBox.Show("ลงทะเบียนเรียบร้อย");
            }
        }

        private void btExport_MouseHover(object sender, EventArgs e)
        {
          //  btExport.BackgroundImage = ImageList.Images[47];
        }

        private void btExport_Click_1(object sender, EventArgs e)
        {
            saveFinger();
        }

        private void ctrlControlBar2_Load_1(object sender, EventArgs e)
        {

        }

        private void ctrlControlBar2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ctrlControlBar2_MenuClick(object sender, EventArgs e)
        {

        }

        private void ctrlControlBar2_FingerClick(object sender, EventArgs e)
        {
     
            MainTab.SelectTab(0);
        }

        private void ctrlControlBar2_OnAboutClick(object sender, EventArgs e)
        {
     
            MainTab.SelectTab(2);
        }

        private void ctrlControlBar2_OnExitClick(object sender, EventArgs e)
        {

            confirmClose();
        }

        private void ctrlControlBar2_OnSettingClick(object sender, EventArgs e)
        {
 
            MainTab.SelectTab(1);
        }

        private void ctrlControlBar3_FingerClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(0);
        }

        private void ctrlControlBar3_OnSettingClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(1);
        }

        private void ctrlControlBar3_OnAboutClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(2);
        }

        private void ctrlControlBar3_OnExitClick(object sender, EventArgs e)
        {
            confirmClose();
        }
        private void confirmClose()
        {
            DialogResult result = MessageBox.Show("ออกจากโปรแกรม", "ยืนยัน", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void ctrlControlBar1_FingerClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(0);
        }

        private void ctrlControlBar1_OnAboutClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(2);
        }

        private void ctrlControlBar1_OnExitClick(object sender, EventArgs e)
        {
            confirmClose();
        }

        private void ctrlControlBar1_OnSettingClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(1);
        }

        private void ctrlControlBar4_FingerClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(0);
        }

        private void ctrlControlBar4_OnAboutClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(2);
        }

        private void ctrlControlBar4_OnExitClick(object sender, EventArgs e)
        {
            confirmClose();
        }

        private void ctrlControlBar4_OnSettingClick(object sender, EventArgs e)
        {
            MainTab.SelectTab(1);
        }
        private void สแกนลายนวมอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.SelectTab(0);
        }

        private void ตงคาใชงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.SelectTab(1);
        }

        private void ลงทะเบยนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.SelectTab(2);
        }

        private void เกยวกบเราToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.SelectTab(3);
        }

        private void ceoFlash_Enter(object sender, EventArgs e)
        {

        }

        private void aboutus_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (!ProductKey.isActived())
            {
                MessageBox.Show("Demo Version"+Environment.NewLine+"ไม่สามารถใช้งานฟังก์ชันนี้ได้กรุณาลงทะเบียนเพื่อใช้งานเวอร์ชั่นเต็ม");
            }
            else
            {
                saveFinger();
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
           

        }

        private void fileToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String SoftwareName;
            SoftwareName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            CEO_FingerLicense.License.SaveRegistryValue(SoftwareName, "Username", username.Text);
            CEO_FingerLicense.License.SaveRegistryValue(SoftwareName, "Password", password.Text);
            CEO_FingerLicense.License.SaveRegistryValue(SoftwareName, "FilePath", txtSetting.Text);
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void saveProfile(String Username,String Password)
        {

        }

        private void เกยวกบซอฟตแวรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTab.SelectTab(3);
        }

        private void ลงทะเบยนToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainTab.SelectTab(2);
        }

        private void ctrlControlBar3_Load(object sender, EventArgs e)
        {

        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirmClose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            Setting.Text = "";
        }

        private  void คมอการใชงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Path.GetDirectoryName(Application.ExecutablePath);
           String tmpPath=Path.Combine(filePath,"Manual","manual.pdf"); 
           System.Diagnostics.Process.Start(tmpPath);
        }

        private void เวบไซตซอซอฟตแวรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ceo-software.co.th");
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            if (!ProductKey.isActived())
            {
                MessageBox.Show("โปรแกรมรุ่นทดลองใช้กรุณาทำการลงทะเบียน");
            }
            else
            {
                saveFinger();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picStatus.Image=ImageList.Images[48];
        }

        private void picStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
