using System;
using System.Collections;
using System.Drawing;
using System.IO;
namespace CEO_Devices.SmartCard
{
	public class CEO_SmartCard
	{
		public enum Language
		{
			English,
			Thai
		}
		public enum SexType
		{
			Male,
			Female
		}
		private string nationalID;
		private string thaiTitle;
		private string thaiName;
		private string thaiMiddleName;
		private string thaiSurname;
		private string englishTitle;
		private string englishName;
		private string englishMiddleName;
		private string englishSurname;
		private string address;
		private int moo;
		private string trok;
		private string soi;
		private string thanon;
		private string tumbol;
		private string amphur;
		private string province;
		private int sex;
		private string birthDate;
		private string issueDate;
		private string expireDate;
		private string issuePlace;
		private Image photo;
		public string NationalID
		{
			get
			{
				return this.nationalID;
			}
			set
			{
				this.nationalID = value;
			}
		}
		public string ThaiTitle
		{
			get
			{
				return this.thaiTitle;
			}
			set
			{
				this.thaiTitle = value;
			}
		}
		public string ThaiName
		{
			get
			{
				return this.thaiName;
			}
			set
			{
				this.thaiName = value;
			}
		}
		public string ThaiMiddleName
		{
			get
			{
				return this.thaiMiddleName;
			}
			set
			{
				this.thaiMiddleName = value;
			}
		}
		public string ThaiSurname
		{
			get
			{
				return this.thaiSurname;
			}
			set
			{
				this.thaiSurname = value;
			}
		}
		public string EnglishTitle
		{
			get
			{
				return this.englishTitle;
			}
			set
			{
				this.englishTitle = value;
			}
		}
		public string EnglishName
		{
			get
			{
				return this.englishName;
			}
			set
			{
				this.englishName = value;
			}
		}
		public string EnglishMiddleName
		{
			get
			{
				return this.englishMiddleName;
			}
			set
			{
				this.englishMiddleName = value;
			}
		}
		public string EnglishSurname
		{
			get
			{
				return this.englishSurname;
			}
			set
			{
				this.englishSurname = value;
			}
		}
        private String StartCardDate(String date)
        {
           
                String tmpYear = "";
                String tmpMonth = "";
                String tmpDay = "";
                String tmpStringDate = "";
                tmpYear = date.Substring(0,4);
                tmpMonth = date.Substring(4, 2);
                tmpDay = date.Substring(6, 2);
                tmpStringDate = tmpDay + "/" + tmpMonth + "/" + tmpYear;
                DateTime tmpdate = new DateTime(Int32.Parse(tmpYear), Int32.Parse(tmpMonth), Int32.Parse(tmpDay));
                return tmpdate.AddYears(-543).ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("th-TH"));
                
        }
		public string Birthdate
		{
			get
			{

                return StartCardDate(this.birthDate);
                
			}
			set
			{
				this.birthDate = value;
			}
		}
		public int Sex
		{
			get
			{
				return this.sex;
			}
			set
			{
				this.sex = value;
			}
		}
		public string Address
		{
			get
			{
				return this.address;
			}
			set
			{
				this.address = value;
			}
		}
		public int Moo
		{
			get
			{
				return this.moo;
			}
			set
			{
				this.moo = value;
			}
		}
		public string Trok
		{
			get
			{
				return this.trok;
			}
			set
			{
				this.trok = value;
			}
		}
		public string Soi
		{
			get
			{
				return this.soi;
			}
			set
			{
				this.soi = value;
			}
		}
		public string Thanon
		{
			get
			{
				return this.thanon;
			}
			set
			{
				this.thanon = value;
			}
		}
		public string Tumbol
		{
			get
			{
				return this.tumbol;
			}
			set
			{
				this.tumbol = value;
			}
		}
		public string Amphur
		{
			get
			{
				return this.amphur;
			}
			set
			{
				this.amphur = value;
			}
		}
		public string Province
		{
			get
			{
				return this.province;
			}
			set
			{
				this.province = value;
			}
		}
		public string IssuePlace
		{
			get
			{
				return this.issuePlace;
			}
			set
			{
				this.issuePlace = value;
			}
		}
		public string IssueDate
		{
			get
			{
				return this.issueDate;
			}
			set
			{
				this.issueDate = value;
			}
		}
		public string ExpireDate
		{
			get
			{
                return StartCardDate(this.expireDate);

           	}
			set
			{
				this.expireDate = value;
			}
		}
		public Image Photo
		{
			get
			{
				return this.photo;
			}
		}
		public CEO_SmartCard()
		{
			this.nationalID = string.Empty;
			this.thaiTitle = string.Empty;
			this.thaiName = string.Empty;
			this.thaiMiddleName = string.Empty;
			this.thaiSurname = string.Empty;
			this.englishTitle = string.Empty;
			this.englishName = string.Empty;
			this.englishMiddleName = string.Empty;
			this.englishSurname = string.Empty;
			this.address = string.Empty;
			this.moo = 0;
			this.trok = string.Empty;
			this.soi = string.Empty;
			this.thanon = string.Empty;
			this.tumbol = string.Empty;
			this.amphur = string.Empty;
			this.province = string.Empty;
			this.issuePlace = string.Empty;
			this.sex = 1;
			this.birthDate = string.Empty;
			this.issueDate = string.Empty;
			this.expireDate = string.Empty;
			this.photo = null;
		}
		public string GetFieldValue(int fieldIndex)
		{
			string result = string.Empty;
			switch (fieldIndex)
			{
			case 0:
				result = this.nationalID;
				break;
			case 1:
				result = this.thaiTitle;
				break;
			case 2:
				result = this.thaiName;
				break;
			case 3:
				result = this.thaiMiddleName;
				break;
			case 4:
				result = this.thaiSurname;
				break;
			case 5:
				result = this.englishTitle;
				break;
			case 6:
				result = this.englishName;
				break;
			case 7:
				result = this.englishMiddleName;
				break;
			case 8:
				result = this.englishSurname;
				break;
			case 9:
				result = this.birthDate;
				break;
			case 10:
				result = this.sex.ToString();
				break;
			case 11:
				result = this.address;
				break;
			case 12:
				if (this.moo > 0)
				{
					result = this.moo.ToString();
				}
				break;
			case 13:
				result = this.trok;
				break;
			case 14:
				result = this.soi;
				break;
			case 15:
				result = this.thanon;
				break;
			case 16:
				result = this.tumbol;
				break;
			case 17:
				result = this.amphur;
				break;
			case 18:
				result = this.province;
				break;
			case 19:
				result = this.issuePlace;
				break;
			case 20:
				result = this.issueDate;
				break;
			case 21:
				result = this.expireDate;
				break;
			}
			return result;
		}
		public void SetFullName(CEO_SmartCard.Language lang, string fullName)
		{
			ArrayList arrayList = new ArrayList(fullName.Split(new char[]
			{
				' '
			}));
			arrayList.TrimToSize();
			if (lang == CEO_SmartCard.Language.English)
			{
				switch (arrayList.Count)
				{
				case 0:
					this.englishName = fullName;
					break;
				case 1:
					this.englishName = arrayList[0].ToString();
					break;
				case 2:
					this.englishName = arrayList[0].ToString();
					this.englishSurname = arrayList[1].ToString();
					break;
				case 3:
					this.englishTitle = arrayList[0].ToString();
					this.englishName = arrayList[1].ToString();
					this.englishSurname = arrayList[2].ToString();
					break;
				default:
					this.englishTitle = arrayList[0].ToString();
					this.englishName = arrayList[1].ToString();
					this.englishMiddleName = arrayList[2].ToString();
					this.englishSurname = arrayList[3].ToString();
					break;
				}
			}
			if (lang == CEO_SmartCard.Language.Thai)
			{
				switch (arrayList.Count)
				{
				case 0:
					this.thaiName = fullName;
					return;
				case 1:
					this.thaiName = arrayList[0].ToString();
					return;
				case 2:
					this.thaiName = arrayList[0].ToString();
					this.thaiSurname = arrayList[1].ToString();
					return;
				case 3:
					this.thaiTitle = arrayList[0].ToString();
					this.thaiName = arrayList[1].ToString();
					this.thaiSurname = arrayList[2].ToString();
					return;
				default:
					this.thaiTitle = arrayList[0].ToString();
					this.thaiName = arrayList[1].ToString();
					this.thaiMiddleName = arrayList[2].ToString();
					this.thaiSurname = arrayList[3].ToString();
					break;
				}
			}
		}
		public string GetFullName(CEO_SmartCard.Language language)
		{
			string text = string.Empty;
			if (language == CEO_SmartCard.Language.English)
			{
				text = this.englishTitle;
				if (this.englishTitle != null)
				{
					text += " ";
				}
				text += this.englishName;
				if (this.englishName != null)
				{
					text += " ";
				}
				text += this.englishMiddleName;
				if (this.englishMiddleName != null)
				{
					text += " ";
				}
				text += this.englishSurname;
			}
			if (language == CEO_SmartCard.Language.Thai)
			{
				text = this.thaiTitle;
				if (this.thaiTitle != null)
				{
					text += " ";
				}
				text += this.thaiName;
				if (this.thaiName != null)
				{
					text += " ";
				}
				text += this.thaiMiddleName;
				if (this.thaiMiddleName != null)
				{
					text += " ";
				}
				text += this.thaiSurname;
			}
			return text;
		}
		public string GetAddress()
		{
			string text = this.address;
			if (this.address != null)
			{
				text += " ";
			}
			if (this.moo > 0)
			{
				text = text + "หมู่ที่ " + this.moo.ToString() + " ";
			}
			if (!string.IsNullOrEmpty(this.trok))
			{
				text = text + "ตรอก" + this.trok + " ";
			}
			if (!string.IsNullOrEmpty(this.soi))
			{
				text = text + "ซ." + this.soi + " ";
			}
			if (!string.IsNullOrEmpty(this.thanon))
			{
				text = text + "ถ." + this.thanon + " ";
			}
			if (this.province == "กรุงเทพมหานคร")
			{
				if (this.tumbol != null)
				{
					text = text + this.tumbol + " ";
				}
				if (this.amphur != null)
				{
					text = text + "เขต" + this.amphur + " ";
				}
				text += this.province;
			}
			else
			{
				if (this.tumbol != null)
				{
					text = text + "ต." + this.tumbol + " ";
				}
				if (this.amphur != null)
				{
					text = text + "อ." + this.amphur + " ";
				}
				text = text + "จ." + this.province;
			}
			return text;
		}
		public void SetPhoto(byte[] photoByteArray)
		{
			MemoryStream stream = new MemoryStream(photoByteArray);
			this.photo = Image.FromStream(stream);
		}
	}
}
