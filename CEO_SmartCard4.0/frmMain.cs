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
           // register.SoftwareCode = "CEO-001";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
            TextWriter tw = new StreamWriter("c://"+tmpFileName+".txt");
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
    }
}
