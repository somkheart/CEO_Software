using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEO_FPM_V3._0_Standard
{
    public partial class frmLogin : Form
    {
        public frmMain _frmMain = new frmMain();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login();
            
        }
        private void Login()
        {

            String SoftwareName,username,password;
            SoftwareName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            username = CEO_FingerLicense.License.GetRegistryValue(SoftwareName,"username");
            password = CEO_FingerLicense.License.GetRegistryValue(SoftwareName,"password");
            if (txtUser.Text != username || txtPassword.Text != password)
            {
                MessageBox.Show("Username/Password ไม่ถูกต้อง ");
                txtPassword.Text = "";
                return;
            }
            if (!_frmMain.IsDisposed)
            {
                _frmMain.Show();
            }
            else
            {
                _frmMain = new frmMain();
                _frmMain.Show();
            }
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
              String SoftwareName;
              SoftwareName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
              if (CEO_FingerLicense.License.isExistKey(SoftwareName))
              {
                  txtVersion.Text = "Standard";
              }
              else
              {
                  txtVersion.Text = "Demo";
              }
        }
    }
}
