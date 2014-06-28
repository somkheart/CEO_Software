using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
namespace PG.SerialKeyMaker.Utility.API
{
	public class ValidatedKey
	{
		private List<string> m_strFreeformItems;
		private string m_strFreeformText;
		public DateTime DateCreated;
		public DateTime DateValidThrough;
		public string ValidVersion;
		public bool Expires;
		public bool IsCurrentlyValid;
		public bool PublicKeyValidates;
		public string Key;
		public bool Feature1;
		public bool Feature2;
		public bool Feature3;
		public bool Feature4;
		public bool Feature5;
		public bool UsesMachineCode;
		public int MachineCode;
		public bool MachineCodeValidates;
		public string FreeformText
		{
			get
			{
				if (string.IsNullOrEmpty(this.m_strFreeformText))
				{
					this.m_strFreeformText = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l();
				}
				return this.m_strFreeformText;
			}
			set
			{
				this.m_strFreeformText = value;
			}
		}
		public List<string> FreeformTextItems
		{
			get
			{
				string item = string.Empty;
				checked
				{
					List<string> list;
					try
					{
						string[] array = this.FreeformText.Split(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.z().ToCharArray());
						list = new List<string>();
						if (array.Length > 0)
						{
							string[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								string item2 = array2[i];
								list.Add(item2);
							}
						}
						else
						{
							item = this.FreeformText;
							list.Add(item);
						}
					}
					catch (Exception expr_5F)
					{
						ProjectData.SetProjectError(expr_5F);
						list = new List<string>();
						item = this.FreeformText;
						list.Add(item);
						ProjectData.ClearProjectError();
					}
					return list;
				}
			}
		}
		public ValidatedKey()
		{
			this.m_strFreeformText = string.Empty;
		}
	}
}
