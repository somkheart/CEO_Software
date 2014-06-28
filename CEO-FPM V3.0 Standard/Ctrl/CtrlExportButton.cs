using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEO_FPM_V3._0_Standard.Ctrl
{
    public partial class CtrlExportButton : UserControl
    {
        public CtrlExportButton()
        {
            InitializeComponent();
            ExportList.Image = BtList.Images[0];
            ExportList.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ExportList.Image = BtList.Images[0];
            ExportList.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void ExportList_Click(object sender, EventArgs e)
        {

        }

        private void ExportList_MouseLeave(object sender, EventArgs e)
        {
            ExportList.Image = BtList.Images[1];
            ExportList.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
