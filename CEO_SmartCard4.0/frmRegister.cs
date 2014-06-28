using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEO_SmartCard4._0
{
    public partial class frmRegister : Form
    {
        private String _SoftwareCode;

        public String SoftwareCode
        {
            get { return _SoftwareCode; }
            set { _SoftwareCode = value; }
        }
        public frmRegister()
        {
            InitializeComponent();
            lisenseBox.SoftwareCode = this.SoftwareCode;
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
        private void frmRegister_LocationChanged(object sender, EventArgs e)
        {
 
        }
        private void lisense1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
