using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CEO_Devices;

namespace CEO_KEYGEN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSerial();
        }
        private void LoadSerial()
        {
            String tmpCPU = CEO_Devices.CPU.GetCPUKey();
            String tmpMac = CEO_Devices.Network.GetMacAddressKey();

            txtProductKey.Text = tmpCPU + "-" + tmpMac;
            SoftwareInfo tmpSoftware = new SoftwareInfo();

            tmpSoftware.SoftwareCode = "INS01";
            tmpSoftware.SoftwareName = "โปรแกรมบัตรประชาชน";
            List<DealerInfo> dealerList = new List<DealerInfo>();
            DealerInfo dealerInfo;

            dealerInfo = new DealerInfo();
            dealerInfo.DealerID = "INS01";
            dealerInfo.DealerName = "บริษัทอินเตอร์ไซต์ประเทศไทย (จำกัด)";
            dealerList.Add(dealerInfo);

            cbDealerID.ValueMember = "DealerName";
            cbDealerID.ValueMember = "DealerID";
            cbDealerID.DataSource = dealerList;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtSerialKey.Text = CEO_FingerLicense.License.GetSerialKey(this.txtProductKey.Text, cbDealerID.ValueMember, cbProgram.ValueMember);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
