using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CEO_Devices.SmartCard
{
    public class CEO_SmartCardProfile
    {
        private ISmartCardProfile card;
        private string appletVersion;
        private bool profileLoaded;
        private bool photoLoaded;
        public int Initialize(ISmartCardReader reader)
        {
            string cardAtrString = reader.GetCardAtrString();
            if (cardAtrString =="3B670000A81041001F9000")
            {
                this.card = new SmartCardV2();
            }
            else
            {
                this.card = new SmartCardV3();
            }
            int num = 5;
            int num2 = -1;
            while (num-- > 0)
            {
                num2 = this.card.StartApplet(reader, out this.appletVersion);
                if (num2 == 0)
                {
                    break;
                }
                Thread.Sleep(500);
            }
            return num2;
        }
        public int Load(object ctl, bool photo)
        {
            if (this.card == null)
            {
                return -5090;
            }
            int num = this.card.LoadProfile(ctl);
            if (num != 0)
            {
                return num;
            }
            this.profileLoaded = true;
            if (photo)
            {
                num = this.card.LoadPhoto(ctl);
                if (num == 0)
                {
                    this.photoLoaded = true;
                }
            }
            return num;
        }
        public CEO_SmartCard GetProfile()
        {
            if (this.card == null)
            {
                return null;
            }
            CEO_SmartCard cardHolderProfile = new CEO_SmartCard();
          // this.profileLoaded = true;
            if (this.profileLoaded)
            {
                cardHolderProfile.NationalID = this.card.GetFieldValue(CEO_ProfileField.NationalID);
                cardHolderProfile.ThaiTitle = this.card.GetFieldValue(CEO_ProfileField.ThaiTitle);
                cardHolderProfile.ThaiName = this.card.GetFieldValue(CEO_ProfileField.ThaiName);
                cardHolderProfile.ThaiMiddleName = this.card.GetFieldValue(CEO_ProfileField.ThaiMiddleName);
                cardHolderProfile.ThaiSurname = this.card.GetFieldValue(CEO_ProfileField.ThaiSurname);
                cardHolderProfile.EnglishTitle = this.card.GetFieldValue(CEO_ProfileField.EnglishTitle);
                cardHolderProfile.EnglishName = this.card.GetFieldValue(CEO_ProfileField.EnglishName);
                cardHolderProfile.EnglishMiddleName = this.card.GetFieldValue(CEO_ProfileField.EnglishMiddleName);
                cardHolderProfile.EnglishSurname = this.card.GetFieldValue(CEO_ProfileField.EnglishSurname);
                cardHolderProfile.Birthdate = this.card.GetFieldValue(CEO_ProfileField.BirthDate);
                cardHolderProfile.Sex = int.Parse(this.card.GetFieldValue(CEO_ProfileField.Sex));
                cardHolderProfile.Address = this.card.GetFieldValue(CEO_ProfileField.Address);
                string text = this.card.GetFieldValue(CEO_ProfileField.Moo);
                if (string.IsNullOrEmpty(text))
                {
                    cardHolderProfile.Moo = 0;
                }
                else
                {
                    if (text.Length > 8)
                    {
                        text = text.Substring(8);
                    }
                    try
                    {
                        cardHolderProfile.Moo = int.Parse(text);
                    }
                    catch
                    {
                        MessageBox.Show("หมู่ที่ไม่ถูกต้อง = " + text);
                        cardHolderProfile.Moo = 0;
                    }
                }
                cardHolderProfile.Trok = this.card.GetFieldValue(CEO_ProfileField.Trok);
                cardHolderProfile.Soi = this.card.GetFieldValue(CEO_ProfileField.Soi);
                cardHolderProfile.Thanon = this.card.GetFieldValue(CEO_ProfileField.Thanon);
                cardHolderProfile.Tumbol = this.card.GetFieldValue(CEO_ProfileField.Tumbol);
                cardHolderProfile.Amphur = this.card.GetFieldValue(CEO_ProfileField.Amphur);
                cardHolderProfile.Province = this.card.GetFieldValue(CEO_ProfileField.Province);
                cardHolderProfile.IssuePlace = this.card.GetFieldValue(CEO_ProfileField.IssuePlace);
                cardHolderProfile.IssueDate = this.card.GetFieldValue(CEO_ProfileField.IssueDate);
                cardHolderProfile.ExpireDate = this.card.GetFieldValue(CEO_ProfileField.ExpireDate);
                bool flag = cardHolderProfile.Province.Contains("กรุงเทพ");
                string keyword = "ตำบล";
                string keyword2 = "อำเภอ";
                if (flag)
                {
                    keyword = "แขวง";
                    keyword2 = "เขต";
                }
                cardHolderProfile.Trok = this.TrimRegionTitle(cardHolderProfile.Trok, "ตรอก");
                cardHolderProfile.Soi = this.TrimRegionTitle(cardHolderProfile.Soi, "ซอย");
                cardHolderProfile.Thanon = this.TrimRegionTitle(cardHolderProfile.Thanon, "ถนน");
                cardHolderProfile.Tumbol = this.TrimRegionTitle(cardHolderProfile.Tumbol, keyword);
                cardHolderProfile.Amphur = this.TrimRegionTitle(cardHolderProfile.Amphur, keyword2);
                cardHolderProfile.Province = this.TrimRegionTitle(cardHolderProfile.Province, "จังหวัด");
            }
            if (this.photoLoaded)
            {
                byte[] photo = this.card.GetPhoto();
                if (photo != null)
                {
                    cardHolderProfile.SetPhoto(photo);
                }
            }
            return cardHolderProfile;
        }
        private string TrimRegionTitle(string regionName, string keyword)
        {
            if (string.IsNullOrEmpty(regionName))
            {
                return string.Empty;
            }
            int length = keyword.Length;
            if (regionName.Length > length && regionName.Substring(0, length) == keyword)
            {
                return regionName.Substring(length);
            }
            return regionName;
        }
        public string GetVersion()
        {
            return this.appletVersion;
        }
        public int GetLastError()
        {
            return 0;
        }
        public string GetMessage(int error)
        {
            return null;
        }
    }
}
