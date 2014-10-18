using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CEO_TestScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEO_Registry tmpRegis = new CEO_Registry();
            MessageBox.Show(tmpRegis.GetProductKey("CEO-SOFTWARE") + tmpRegis.GetSerialKey("CEO-SOFTWARE"));
           // tmpRegis.Write("CEO-SOFTWARE", "1111", "1222");
        //   MessageBox.Show(name);
        }

    }
}
