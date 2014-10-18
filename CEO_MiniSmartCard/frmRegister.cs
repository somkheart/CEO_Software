using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CEO_FingerLicense;

namespace CEO_MiniSmartCard
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        private void setDisable()
        {
            txtSerialNumber.Enabled = false;
            txtProductKey.Enabled = false;
        }
        public string SoftwareCode;
        public string SoftwareName;
        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtProductKey.Text = CEO_FingerLicense.SoftwareKey.GetProductKey();
            bool check = SoftwareKey.checkRegistedKey(this.SoftwareName);
            CEO_FingerLicense.CEO_Registry regis = new CEO_Registry();
            if (regis.checkKey("INTERSITE", this.SoftwareCode, this.txtSerialNumber.Text))
            {
                OK.Enabled = false;
                Cancle.Enabled = false;
                setDisable();
                regis.Write(this.SoftwareName, "INERSITE", txtProductKey.Text, txtSerialNumber.Text);
            }

        }
        private void OK_Click(object sender, EventArgs e)
        {
            CEO_FingerLicense.CEO_Registry regis = new CEO_Registry();
            if (regis.checkKey("INTERSITE", this.SoftwareCode, this.txtSerialNumber.Text))
            {
                regis.Write(this.SoftwareName, "INERSITE", txtProductKey.Text, txtSerialNumber.Text);
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบ Serial Key ไม่ถูกต้อง ");
            }

        }
        private void LicenseBox_Enter(object sender, EventArgs e)
        {

        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
