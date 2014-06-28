using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
namespace PG.SerialKeyMaker.Utility.API
{
	public class classLicense : classLicenseBase
	{
		public enum FeaturesUnlocked
		{
			A = 2,
			a = 4,
			B = 8,
			b = 16,
			C = 32
		}
		private new classLogging A;
		private new string A;
		public classLogging LogObject
		{
			get
			{
				if (this.A == null)
				{
					this.A.LoggingIsEnabled = true;
				}
				return this.A;
			}
			set
			{
				this.A = value;
			}
		}
		public int LocalMachineCode
		{
			get
			{
				return this.A();
			}
		}
		public string[,,] MatrixLetters
		{
			get
			{
				return base.A();
			}
		}
		public string PrivateKey
		{
			get
			{
				return base.B();
			}
			set
			{
				this.A = value;
				base.A(value);
			}
		}
		public int Makers
		{
			get
			{
				return base.a();
			}
		}
		public classLicense()
		{
		}
		public classLicense(string p_strPrivateKey, classLogging p_objLogObject) : base(p_strPrivateKey, p_objLogObject)
		{
			this.A = p_objLogObject;
		}
		public classLicense(classLogging p_objLogObject) : base(p_objLogObject)
		{
			this.A = p_objLogObject;
		}
		public ValidatedKey ValidateKey(string EncryptedString)
		{
			return this.A(EncryptedString);
		}
		private ValidatedKey A(string EncryptedString)
		{
			ValidatedKey validatedKey = base.B(EncryptedString, this.LocalMachineCode);
			if (validatedKey != null)
			{
				validatedKey.MachineCode = this.LocalMachineCode;
			}
			return validatedKey;
		}
		public ValidatedKey ValidateKey(string EncryptedString, int p_intMachineCode)
		{
			return this.A(EncryptedString, p_intMachineCode);
		}
		private ValidatedKey A(string EncryptedString, int p_intMachineCode)
		{
			ValidatedKey validatedKey = base.B(EncryptedString, p_intMachineCode);
			if (validatedKey != null)
			{
				validatedKey.MachineCode = this.LocalMachineCode;
			}
			return validatedKey;
		}
		public string DecryptMD5(string p_strTextToDecrypt, string p_strSaltValue)
		{
			return base.B(p_strTextToDecrypt, p_strSaltValue);
		}
		private new int A()
		{
			int result = -1;
			try
			{
				string text = modMain.GetConfigSetting(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.w());
				if (string.IsNullOrEmpty(text))
				{
					try
					{
						text = Interaction.GetSetting(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.X(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.x(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.w(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l());
					}
					catch (Exception expr_31)
					{
						ProjectData.SetProjectError(expr_31);
						ProjectData.ClearProjectError();
					}
				}
				try
				{
					text = this.DecryptMD5(text, PP.A());
				}
				catch (Exception expr_4F)
				{
					ProjectData.SetProjectError(expr_4F);
					text = string.Empty;
					ProjectData.ClearProjectError();
				}
				if (string.IsNullOrEmpty(text))
				{
					classDiskInformation diskInformation = classHardwareInformation.GetDiskInformation();
					text = diskInformation.Signature + diskInformation.Size + diskInformation.SystemName;
					string text2 = classLicenseBase.E(text);
					if (!string.IsNullOrEmpty(text2))
					{
						result = Conversions.ToInteger(text2);
					}
					modMain.WriteConfigSetting(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.w(), this.EncryptMD5(text2, PP.A()));
					try
					{
						Interaction.SaveSetting(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.X(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.x(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.w(), this.EncryptMD5(text2, PP.A()));
						return result;
					}
					catch (Exception expr_E0)
					{
						ProjectData.SetProjectError(expr_E0);
						ProjectData.ClearProjectError();
						return result;
					}
				}
				result = Conversions.ToInteger(text);
			}
			catch (Exception expr_F8)
			{
				ProjectData.SetProjectError(expr_F8);
				result = -1;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		public string MakeDemoKey(string p_strPrivateKey, int p_intDays, classLicense.FeaturesUnlocked p_intUnlockCode)
		{
			return base.A(p_strPrivateKey, p_intDays, p_intUnlockCode);
		}
		public string EncryptMD5(string p_strTextToEncrypt, string p_strSaltValue)
		{
			return base.a(p_strTextToEncrypt, p_strSaltValue);
		}
		public string GetUnRandomLetter(string p_UnLetter)
		{
			return base.d(p_UnLetter);
		}
		public string GetLetter(int p_intNumber, int p_intSeries)
		{
			return base.a(p_intNumber, p_intSeries);
		}
		public string GetRandomLetter()
		{
			return base.D();
		}
		public string Encrypt(string plainText, int p_intUnlockCode)
		{
			return base.C(plainText, p_intUnlockCode);
		}
		public byte[] EncryptMD5_Byte(byte[] p_strDataToEncrypt, string p_strSaltValue)
		{
			return base.A(p_strDataToEncrypt, p_strSaltValue);
		}
		public byte[] DecryptMD5_Byte(byte[] p_strDataToEncrypt, string p_strSaltValue, int p_intFileBufferLength)
		{
			return base.A(p_strDataToEncrypt, p_strSaltValue, p_intFileBufferLength);
		}
		public string Encrypt_GP(string p_strPublicKey)
		{
			return classLicenseBase.E(p_strPublicKey);
		}
		public string Decrypt(string p_strEncryptedString)
		{
			return base.D(p_strEncryptedString);
		}
		public ValidatedKey ParseKey(string p_objKey, int p_intMachineKey)
		{
			return base.b(p_objKey, p_intMachineKey);
		}
		public bool RandomsMatch(string p_strKey)
		{
			return base.b(p_strKey);
		}
		public bool ValidateRandoms(string p_strA, string p_strB)
		{
			return base.A(p_strA, p_strB);
		}
		public int ReadFeatureCode(string p_strLetter)
		{
			return base.c(p_strLetter);
		}
	}
}
