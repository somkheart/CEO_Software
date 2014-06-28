using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CEO_Devices.SmartCard
{
    public partial class ctlSmardCard : UserControl
    {

        private CEO_Configurations config;

        public CEO_Configurations Config
        {
            get { return config; }
            set { config = value; }
        }
        private CEO_WinPCSC reader;
        private CEO_SmartCard _SmartCard;
        public CEO_SmartCard SmartCard
        {
            get { return _SmartCard; }
            set { _SmartCard = value; }
        }
        public ctlSmardCard()
        {
            InitializeComponent();
            this.config = new CEO_Configurations();
            reader = new CEO_WinPCSC();
        }

        private void ctlSmardCard_Load(object sender, EventArgs e)
        {
            cbSmartCard.DataSource= reader.GetReaderLists();
        }
        public CEO_SmartCard  getSmartCardInfo()
        {
            cbSmartCard.DataSource = reader.GetReaderLists();
            reader.SelectReader(cbSmartCard.Text);
            bool connect = reader.Connect();
            if (connect)
            {
                String tmpCard = reader.GetCardAtrString();
                reader.GetCardStatus();
                CEO_SmartCardProfile tmpSmartCard = new CEO_SmartCardProfile();
                frmProgress formProgress = null;
                tmpSmartCard.Initialize(this.reader);
                int num = tmpSmartCard.Load(formProgress,this.config.loadPhoto);
                return  tmpSmartCard.GetProfile();

            }
            else
            {
                MessageBox.Show("ไม่สำเร็จ");
                return null;
            }
        }
        public String GetJsonSmartCardInfo()
        {
            cbSmartCard.DataSource = reader.GetReaderLists();
            reader.SelectReader(cbSmartCard.Text);
            bool connect = reader.Connect();
            if (connect)
            {
                String tmpCard = reader.GetCardAtrString();
                reader.GetCardStatus();
                CEO_SmartCardProfile tmpSmartCard = new CEO_SmartCardProfile();
                frmProgress formProgress = null;
                tmpSmartCard.Initialize(this.reader);
                int num = tmpSmartCard.Load(formProgress, this.config.loadPhoto);
                return JsonConvert.SerializeObject(this.getSmartCardInfo());

            }
            else
            {
                MessageBox.Show("ไม่สำเร็จ");
                return null;
            }
        }
        private void cbSmartCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
