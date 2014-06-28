using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEO_Devices.SmartCard
{
    public partial class ctlSmardCardPanel : UserControl
    {
        public void SetValue(CEO_SmartCard  info)
        {
            try
            {
                lbNationalID.Text = info.NationalID;
                lbThaiName.Text = info.GetFullName(CEO_SmartCard.Language.Thai);
                lbEnglishName.Text = info.EnglishTitle + info.EnglishName;
                lbLastName.Text = info.EnglishSurname;
                lbBirthday.Text = info.Birthdate;
                lbAddress.Text = info.GetAddress();
                Picture.Image = info.Photo;
                lbExpireDate.Text = info.ExpireDate;
            }
            catch { }
        }
        public ctlSmardCardPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctlSmardCardPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
