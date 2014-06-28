using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CEO_FingerLicense;

namespace CEO_SmartCard4._0
{
    public partial class frmRegis : Form
    {
        public frmRegis()
        {
            InitializeComponent();
        }
        private String _SoftwareCode;

        public String SoftwareCode
        {
            get { return _SoftwareCode; }
            set { _SoftwareCode = value; }
        }
        private String _DealerID;

        public String DealerID
        {
            get { return _DealerID; }
            set { _DealerID = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.DealerID= txtDealerID.Text;
            String SoftwareCode = txtProductKey.Text;
            String serialKey = "";
            this.SoftwareCode = "SMARTCARD";
            DealerID = txtDealerID.Text;

            if (!String.IsNullOrEmpty(txtDealerID.Text) || !String.IsNullOrEmpty(txtSerialNumber.Text))
            {
                  serialKey = SoftwareKey.GetSerialKey(this.SoftwareCode, txtDealerID.Text, txtProductKey.Text);
                  if (SoftwareKey.checkKey(DealerID, this.SoftwareCode, serialKey))
                  {
                      SoftwareKey.saveSerialKey(DealerID, SoftwareCode, serialKey);
                      setDisable();
                  }
                  else
                  {
                      MessageBox.Show(" Serial Key ไม่ถูกต้อง ");
                      reSet();
                  }
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบ DealerID,SerialNumber ");
                reSet();
            }

        }
        private void reSet()
        {
            txtDealerID.Text = "";
            txtSerialNumber.Text = "";
        }
        private void setDisable()
        {
            txtDealerID.Enabled = false;
            txtSerialNumber.Enabled = false;
            txtProductKey.Enabled = false;
        }
        private void frmRegis_Load(object sender, EventArgs e)
        {
            txtProductKey.Text = CEO_FingerLicense.SoftwareKey.GetProductKey();
            this.SoftwareCode = "INTERSITE";
            bool check=SoftwareKey.checkRegistedKey(this.SoftwareCode);
            if (check)
            {
                String SoftwareCode = SoftwareKey.GetDealerID(this.SoftwareCode);
                String SerialKey = SoftwareKey.GetSerialKey(this.SoftwareCode);
                String DealerID = SoftwareKey.GetDealerID(this.SoftwareCode);
                txtDealerID.Text = DealerID;
                txtSerialNumber.Text = SerialKey;
                OK.Enabled = false;
                Cancle.Enabled = false;
                setDisable();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
