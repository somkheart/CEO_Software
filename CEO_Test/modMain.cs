using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Configuration;
using System.Runtime.CompilerServices;
namespace PG.SerialKeyMaker.Utility.API
{
	[StandardModule]
	public sealed class modMain
	{
		[CompilerGenerated]
		internal class _Closure
		{
			public string A;
			[CompilerGenerated]
			public bool _Lambda(string s)
			{
				return s.Contains(this.A);
			}
		}
		public static string FixString(string p_strStringIn, int p_intNumberofChars)
		{
			string empty = string.Empty;
			if (p_intNumberofChars < 0)
			{
				p_intNumberofChars = 0;
			}
			return Strings.Right(modMain.SafeString(p_strStringIn), p_intNumberofChars).PadLeft(p_intNumberofChars, '0');
		}
		public static string FixCompositeKey(int p_intCompositeKey)
		{
			string text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aW();
			if (p_intCompositeKey <= 0)
			{
				text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aW();
			}
			else
			{
				text = Conversions.ToString(p_intCompositeKey);
				text = modMain.FixString(text, 5);
			}
			return text;
		}
		public static string SafeString(object p_objIn)
		{
			string result = string.Empty;
			if (p_objIn != null)
			{
				try
				{
					result = Conversions.ToString(p_objIn);
				}
				catch (Exception expr_12)
				{
					ProjectData.SetProjectError(expr_12);
					result = string.Empty;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}
		public static bool SafeBoolean(object p_objIN)
		{
			bool result = false;
			try
			{
				if (p_objIN != null)
				{
					result = Conversions.ToBoolean(p_objIN);
				}
			}
			catch (Exception expr_0E)
			{
				ProjectData.SetProjectError(expr_0E);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
		public static int SafeInteger(object p_objIn)
		{
			int result = -1;
			if (p_objIn != null)
			{
				try
				{
					result = Conversions.ToInteger(p_objIn);
				}
				catch (Exception expr_0E)
				{
					ProjectData.SetProjectError(expr_0E);
					result = -1;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}
		public static string MakeReadable(string strText)
		{
			string text = string.Empty;
			checked
			{
				if (!string.IsNullOrEmpty(strText))
				{
					strText = strText.Replace(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Bd(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l());
					char[] array = strText.ToCharArray();
					for (int i = 0; i < array.Length; i++)
					{
						string str = Conversions.ToString(array[i]);
						int num;
						num++;
						text += str;
						if (num == 5)
						{
							text += <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Bd();
							num = 0;
						}
					}
					text = Strings.Mid(text, 1, text.Length - 3) + Strings.Right(text, 3).Replace(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Bd(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l());
				}
				return text;
			}
		}
		public static string RemoveReadability(string strText)
		{
			string text = string.Empty;
			text = strText.Replace(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Bd(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l());
			return text.Replace(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BE(), <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l());
		}
		public static string SafeStringVersion(object p_objIn)
		{
			string text = string.Empty;
			if (p_objIn != null)
			{
				try
				{
					text = Conversions.ToString(p_objIn);
					if (Operators.CompareString(text, <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aS(), false) == 0)
					{
						text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Be();
					}
				}
				catch (Exception expr_27)
				{
					ProjectData.SetProjectError(expr_27);
					text = string.Empty;
					ProjectData.ClearProjectError();
				}
			}
			return text;
		}
		public static string FixDate(DateTime dteIn)
		{
			string text = string.Empty;
			if (Information.IsDate(dteIn) && !Information.IsNothing(dteIn))
			{
				text = Strings.Right(dteIn.Month.ToString().PadLeft(2, '0'), 2);
				text += Strings.Right(dteIn.Day.ToString().PadLeft(2, '0'), 2);
				text += Strings.Right(dteIn.Year.ToString().PadLeft(2, '0'), 2);
			}
			else
			{
				text = string.Empty;
			}
			return text;
		}
		public static string GetConfigSetting(string p_strConfigItemName)
		{
			string result = string.Empty;
			try
			{
				result = ConfigurationManager.AppSettings.Get(p_strConfigItemName);
			}
			catch (Exception expr_14)
			{
				ProjectData.SetProjectError(expr_14);
				ProjectData.ClearProjectError();
			}
			return result;
		}
		public static string WriteConfigSetting(string p_strConfigItemName, string p_strValue)
		{
			try
			{
				Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				if (Array.Exists<string>(configuration.AppSettings.Settings.AllKeys, (string s) => s.Contains(p_strConfigItemName)))
				{
					configuration.AppSettings.Settings[p_strConfigItemName].Value = p_strValue;
				}
				else
				{
					configuration.AppSettings.Settings.Add(p_strConfigItemName, p_strValue);
				}
				configuration.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BF());
			}
			catch (Exception expr_80)
			{
				ProjectData.SetProjectError(expr_80);
				ProjectData.ClearProjectError();
			}
			return p_strValue;
		}
	}
}
