using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEO_Devices.SmartCard
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 100;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                progressBar.Value += 1;
            }

        }
    }
}
