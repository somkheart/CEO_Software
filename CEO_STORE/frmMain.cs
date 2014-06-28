using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace CEO_STORE
{
    public partial class frmMain : Form
    {
 
        public frmMain()
        {
            InitializeComponent();
        }

        private void ตงคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainTab.Controls.Add(new Form());
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tmpDlgResult = MessageBox.Show("ออกจากระบบ", "ยืนยัน", MessageBoxButtons.OKCancel);
            if (tmpDlgResult == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void ผดแลToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] tmpDllList = Directory.GetFiles("Modules","*.dll");
            foreach (String tmpDll in tmpDllList)
            {
                String tmpDllPath = Path.Combine(Application.StartupPath, tmpDll);
                Assembly tmpAssembly = Assembly.LoadFile(tmpDllPath);
                //Type tmpObj = tmpAssembly.GetType("CEO");
                //object obj = Activator.CreateInstance(tmpObj);
                
            }
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
