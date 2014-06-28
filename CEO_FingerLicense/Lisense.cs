using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEO_FingerLicense
{
    public partial class Lisense : UserControl
    {
        private String _SoftwareCode;

        public String SoftwareCode
        {
            get { return _SoftwareCode; }
            set { _SoftwareCode = value; }
        }
        public Lisense()
        {
            InitializeComponent();
            txtDealerID.Focus();
            txtProductKey.Text = CEO_FingerLicense.SoftwareKey.GetProductKey();
            this.SoftwareCode = "INTER01";
        }
        public Lisense(String SoftwareName)
        {
            InitializeComponent();
            txtDealerID.Focus();
            txtProductKey.Text = CEO_FingerLicense.SoftwareKey.GetProductKey();
            LicenseBox.Text=SoftwareName;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             String serialKey = "";
             String SoftwareCode = "";
             serialKey = SoftwareKey.GetSerialKey(this.SoftwareCode, txtDealerID.Text, txtProductKey.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lisense_Load(object sender, EventArgs e)
        {

        }
    }
}
