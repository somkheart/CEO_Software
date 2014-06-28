using System;
using System.Text;
using System.Windows.Forms;
namespace CEO_Devices.SmartCard
{
    internal class SmartCardV3 : ISmartCardProfile
	{
		private struct FieldDescriptor
		{
			public int indexStart;
			public byte subField;
			public int size;
			public FieldDescriptor(int a, byte b, int c)
			{
				this.indexStart = a;
				this.subField = b;
				this.size = c;
			}
		}
		private byte[] cardBuffer = new byte[6000];
        private ISmartCardReader reader;
		private SmartCardV3.FieldDescriptor[] SmartCardFeild = new SmartCardV3.FieldDescriptor[]
		{
			new SmartCardV3.FieldDescriptor(4, 0, 13),
			new SmartCardV3.FieldDescriptor(17, 1, 100),
			new SmartCardV3.FieldDescriptor(17, 2, 100),
			new SmartCardV3.FieldDescriptor(17, 3, 100),
			new SmartCardV3.FieldDescriptor(17, 4, 100),
			new SmartCardV3.FieldDescriptor(117, 1, 100),
			new SmartCardV3.FieldDescriptor(117, 2, 100),
			new SmartCardV3.FieldDescriptor(117, 3, 100),
			new SmartCardV3.FieldDescriptor(117, 4, 100),
			new SmartCardV3.FieldDescriptor(217, 0, 8),
			new SmartCardV3.FieldDescriptor(225, 0, 1),
			new SmartCardV3.FieldDescriptor(5497, 1, 160),
			new SmartCardV3.FieldDescriptor(5497, 2, 160),
			new SmartCardV3.FieldDescriptor(5497, 3, 160),
			new SmartCardV3.FieldDescriptor(5497, 4, 160),
			new SmartCardV3.FieldDescriptor(5497, 5, 160),
			new SmartCardV3.FieldDescriptor(5497, 6, 160),
			new SmartCardV3.FieldDescriptor(5497, 7, 160),
			new SmartCardV3.FieldDescriptor(5497, 8, 160),
			new SmartCardV3.FieldDescriptor(246, 0, 100),
			new SmartCardV3.FieldDescriptor(359, 0, 8),
			new SmartCardV3.FieldDescriptor(367, 0, 8)
		};
		public SmartCardV3()
		{
			Array.Clear(this.cardBuffer, 0, 6000);
		}
        public int StartApplet(ISmartCardReader reader, out string version)
		{
			byte[] appletID = new byte[]
			{
				160,
				0,
				0,
				0,
				84,
				72,
				0,
				1
			};
			this.reader = reader;
			version = string.Empty;
			ushort num = this.SelectApplet(appletID);
			if ((num & 65280) != 24832)
			{
				return -5001;
			}
			byte length = (byte)num;
			byte[] array;
			num = this.GetResponse(length, out array);
			if (num != 36864)
			{
				return -5002;
			}
			int num2 = this.ReadBlock(0, 0, 17, 0);
			if (num2 <= 0)
			{
				return -5003;
			}
			version = Encoding.ASCII.GetString(this.cardBuffer, 0, 4);
			return 0;
		}
		public int LoadProfile(object control)
		{
			ProgressBar progressBar = (ProgressBar)control;
			if (progressBar != null)
			{
				progressBar.Value = 0;
				progressBar.Visible = true;
				progressBar.Maximum = 5635;
				Application.DoEvents();
			}
			SystemException ex = new SystemException();
			try
			{
				int num = this.ReadBlock(0, 0, 226, 0);
				if (num < 0)
				{
					throw ex;
				}
				if (progressBar != null)
				{
					progressBar.Value = 226;
				}
				num = this.ReadBlock(0, 246, 129, 246);
				if (num < 0)
				{
					throw ex;
				}
				if (progressBar != null)
				{
					progressBar.Value = 355;
				}
				num = this.ReadBlock(0, 5497, 160, 5497);
				if (num < 0)
				{
					throw ex;
				}
				if (progressBar != null)
				{
					progressBar.Value = 515;
				}
			}
			catch
			{
				return -1;
			}
			return 0;
		}
		public int LoadPhoto(object control)
		{
			ProgressBar progressBar = (ProgressBar)control;
			int num = 5120;
			ushort num2 = 377;
			int num3 = 377;
			int num4 = num / 200;
			int num5 = num % 200;
			int num6 = 0;
			int num7 = 0;
			if (progressBar != null)
			{
				num7 = progressBar.Value;
			}
			while (num4-- > 0)
			{
				num6 = this.ReadBlock(0, num2, 200, num3);
				if (num6 < 0)
				{
					break;
				}
				num2 += (ushort)num6;
				num3 += num6;
				num7 += num6;
				if (progressBar != null)
				{
					progressBar.Value = num7;
				}
			}
			if (num6 > 0 && num5 > 0)
			{
				num6 = this.ReadBlock(0, num2, (byte)num5, num3);
				num7 += num6;
				if (progressBar != null)
				{
					progressBar.Value = num7;
				}
			}
			if (progressBar != null)
			{
				progressBar.Visible = false;
			}
			if (num6 < 0)
			{
				return -1;
			}
			return 0;
		}
		public string GetNationalID()
		{
			return Encoding.ASCII.GetString(this.cardBuffer, 4, 13);
		}
		public string GetFieldValue(CEO_ProfileField fieldIndex)
		{
			if (this.cardBuffer[0] == 0)
			{
				return string.Empty;
			}
			if (fieldIndex < CEO_ProfileField.NationalID || fieldIndex > CEO_ProfileField.ExpireDate)
			{
				return string.Empty;
			}
			int num = this.SmartCardFeild[(int)fieldIndex].indexStart;
			int num2 = this.SmartCardFeild[(int)fieldIndex].indexStart + this.SmartCardFeild[(int)fieldIndex].size - 1;
			int i = num;
			string result = string.Empty;
			if (this.SmartCardFeild[(int)fieldIndex].subField > 0)
			{
				int num3 = 0;
				while (i < num2)
				{
					if (this.cardBuffer[i] == 35)
					{
						if (++num3 >= (int)this.SmartCardFeild[(int)fieldIndex].subField)
						{
							break;
						}
						num = i + 1;
					}
					i++;
				}
				i--;
			}
			else
			{
				i = num2;
			}
			if (i < num)
			{
				return result;
			}
			while ((this.cardBuffer[i] <= 32 || this.cardBuffer[i] >= 240) && i > num)
			{
				i--;
			}
			int count = i - num + 1;
			if (this.cardBuffer[num] != 0)
			{
				Encoding encoding = Encoding.GetEncoding(874);
				result = encoding.GetString(this.cardBuffer, num, count);
			}
			return result;
		}
		public byte[] GetPhoto()
		{
			byte[] array = new byte[5118];
			Array.Copy(this.cardBuffer, 379, array, 0, 5118);
			return array;
		}
		private int ReadBlock(byte block, ushort offset, byte length, int bufferIndex)
		{
			SmartCardAPDU smartCardAPDU = new SmartCardAPDU();
			smartCardAPDU.CLA = 128;
			smartCardAPDU.INS = 176;
			smartCardAPDU.P1 = Convert.ToByte(offset >> 8);
			smartCardAPDU.P2 = Convert.ToByte((int)(offset & 255));
			smartCardAPDU.Lc = 2;
			smartCardAPDU.Le = 0;
			smartCardAPDU.dataIn[0] = block;
			smartCardAPDU.dataIn[1] = Convert.ToByte(length);
			int num = this.reader.SmartCardExchangeAPDU(smartCardAPDU);
			if (num != 0)
			{
				return -1;
			}
			if ((smartCardAPDU.status & 65280) != 24832)
			{
				return -2;
			}
			int num2 = Convert.ToInt32((int)(smartCardAPDU.status & 255));
			smartCardAPDU.CLA = 0;
			smartCardAPDU.INS = 192;
			smartCardAPDU.P1 = 0;
			smartCardAPDU.P2 = 0;
			smartCardAPDU.Lc = 0;
			smartCardAPDU.Le = Convert.ToByte(num2);
			num = this.reader.SmartCardExchangeAPDU(smartCardAPDU);
			if (num != 0)
			{
				return -3;
			}
			if (smartCardAPDU.status != 36864)
			{
				return -4;
			}
			Array.Copy(smartCardAPDU.dataOut, 0, this.cardBuffer, bufferIndex, num2);
			return num2;
		}
		private ushort SelectApplet(byte[] appletID)
		{
			SmartCardAPDU smartCardAPDU = new SmartCardAPDU();
			smartCardAPDU.CLA = 0;
			smartCardAPDU.INS = 164;
			smartCardAPDU.P1 = 4;
			smartCardAPDU.P2 = 0;
			smartCardAPDU.Lc = 8;
			smartCardAPDU.Le = 0;
			Array.Copy(appletID, smartCardAPDU.dataIn, 8);
			int num = this.reader.SmartCardExchangeAPDU(smartCardAPDU);
			if (num != 0)
			{
				return 0;
			}
			return smartCardAPDU.status;
		}
		private ushort ReadBinary(byte block, ushort offset, byte length)
		{
			SmartCardAPDU smartCardAPDU = new SmartCardAPDU();
			smartCardAPDU.CLA = 128;
			smartCardAPDU.INS = 176;
			smartCardAPDU.P1 = Convert.ToByte(offset >> 8);
			smartCardAPDU.P2 = Convert.ToByte((int)(offset & 255));
			smartCardAPDU.Lc = 2;
			smartCardAPDU.Le = 0;
			smartCardAPDU.dataIn[0] = block;
			smartCardAPDU.dataIn[1] = Convert.ToByte(length);
			int num = this.reader.SmartCardExchangeAPDU(smartCardAPDU);
			if (num != 0)
			{
				return 0;
			}
			return smartCardAPDU.status;
		}
		private ushort GetResponse(byte length, out byte[] arrOutput)
		{
			SmartCardAPDU smartCardAPDU = new SmartCardAPDU();
			smartCardAPDU.CLA = 0;
			smartCardAPDU.INS = 192;
			smartCardAPDU.P1 = 0;
			smartCardAPDU.P2 = 0;
			smartCardAPDU.Lc = 0;
			smartCardAPDU.Le = length;
			int num = this.reader.SmartCardExchangeAPDU(smartCardAPDU);
			arrOutput = null;
			if (num != 0)
			{
				return 0;
			}
			if (smartCardAPDU.status == 36864)
			{
				arrOutput = new byte[smartCardAPDU.dataOut.Length - 2];
				Array.Copy(smartCardAPDU.dataOut, arrOutput, smartCardAPDU.dataOut.Length - 2);
			}
			return smartCardAPDU.status;
		}
	}
}
