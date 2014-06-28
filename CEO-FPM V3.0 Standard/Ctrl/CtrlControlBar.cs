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
    public partial class CtrlControlBar : UserControl
    {
        [Category("Action")]
        [Description("Fires when the value is changed")]
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            // Raise the event
            if (ValueChanged != null)
                ValueChanged(this, e);
        }

        public CtrlControlBar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CtrlControlBar_Load(object sender, EventArgs e)
        {

        }
        [Category("CEO_ACTION")]
        [Description("Fires when the value is changed")]
        public event EventHandler OnExitClick;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (OnExitClick != null)
            {
                OnExitClick(sender, e);
            }
        }
        [Category("CEO_ACTION")]
        [Description("Fires when the value is changed")]
        public event EventHandler OnAboutClick;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (OnAboutClick != null)
            {
                OnAboutClick(sender, e);
            }
        }
        [Category("CEO_ACTION")]
        [Description("Fires when the value is changed")]
        public event EventHandler FingerClick;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FingerClick != null)
            {
                FingerClick(0, EventArgs.Empty);
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pbFinger.Image = ImageButtonList.Images[0];
            pbFinger.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pbFinger_MouseLeave(object sender, EventArgs e)
        {
            pbFinger.Image = ImageButtonList.Images[1];
            pbFinger.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageButtonList.Images[2];
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageButtonList.Images[3];
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            BttExit.Image = ImageButtonList.Images[6];
            BttExit.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            BttExit.Image = ImageButtonList.Images[5];
            BttExit.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void bttAbout_MouseHover(object sender, EventArgs e)
        {

            bttAbout.Image = ImageButtonList.Images[10];
            bttAbout.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void bttAbout_MouseLeave(object sender, EventArgs e)
        {
            bttAbout.Image = ImageButtonList.Images[9];
            bttAbout.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pbFinger_MouseDown(object sender, MouseEventArgs e)
        {

        }
        [Category("CEO_ACTION")]
        [Description("Fires when the value is changed")]
        public event EventHandler OnSettingClick;
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (OnSettingClick != null)
            {
                OnSettingClick(sender, e);
            }
        }
    }
}
