using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
namespace PG.SerialKeyMaker.Utility.API
{
	public class classLogging
	{
		public enum MessageTypes
		{
			e_intNone,
			e_intError,
			e_intInfo,
			e_intSuccess
		}
		private bool m_blnLoggingIsEnabled;
		private string m_strWholeFileNamePassedIn;
		private string m_strLogFileName;
		private string m_strLogFileExtension;
		private string m_strLogPathDirectory;
		private bool m_blnUseHourlyLoggingFilename;
		private bool m_blnTraceIsOn;
		private bool m_blnConsoleIsOn;
		public bool TraceIsOn
		{
			get
			{
				return this.m_blnTraceIsOn;
			}
			set
			{
				this.m_blnTraceIsOn = value;
			}
		}
		public bool ConsoleIsOn
		{
			get
			{
				return this.m_blnConsoleIsOn;
			}
			set
			{
				this.m_blnConsoleIsOn = value;
			}
		}
		public string LogFileExtension
		{
			get
			{
				this.m_strLogFileExtension = this.GetExtension(this.m_strWholeFileNamePassedIn);
				return this.m_strLogFileExtension;
			}
		}
		public bool LoggingIsEnabled
		{
			get
			{
				return this.m_blnLoggingIsEnabled;
			}
			set
			{
				this.m_blnLoggingIsEnabled = value;
			}
		}
		public string LogFileName
		{
			get
			{
				this.m_strLogFileName = this.GetLogFileName(this.m_strWholeFileNamePassedIn);
				return this.m_strLogFileName;
			}
			set
			{
				this.m_strLogFileName = value;
			}
		}
		public string LogPathDirectory
		{
			get
			{
				this.m_strLogPathDirectory = this.GetLogPathDirectory(this.m_strWholeFileNamePassedIn);
				return this.m_strLogPathDirectory;
			}
		}
		public string WholeLogFilePathandName
		{
			get
			{
				if (this.UseHourlyLoggingFilename)
				{
					return string.Concat(new string[]
					{
						this.LogPathDirectory,
						<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aw(),
						this.LogFileName,
						<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aX(),
						DateAndTime.Now.ToString(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ax()),
						this.LogFileExtension
					});
				}
				return this.LogPathDirectory + <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aw() + this.LogFileName + this.LogFileExtension;
			}
		}
		public string LogFilePathandName
		{
			set
			{
				this.m_strWholeFileNamePassedIn = value;
			}
		}
		public bool UseHourlyLoggingFilename
		{
			get
			{
				return this.m_blnUseHourlyLoggingFilename;
			}
			set
			{
				this.m_blnUseHourlyLoggingFilename = value;
			}
		}
		public classLogging(string p_strWholeFileNamePassedIn)
		{
			this.m_blnLoggingIsEnabled = false;
			this.m_strWholeFileNamePassedIn = string.Empty;
			this.m_strLogFileName = string.Empty;
			this.m_strLogFileExtension = string.Empty;
			this.m_strLogPathDirectory = string.Empty;
			this.m_blnUseHourlyLoggingFilename = true;
			this.m_blnTraceIsOn = false;
			this.m_blnConsoleIsOn = false;
			this.m_strWholeFileNamePassedIn = p_strWholeFileNamePassedIn;
		}
		public classLogging()
		{
			this.m_blnLoggingIsEnabled = false;
			this.m_strWholeFileNamePassedIn = string.Empty;
			this.m_strLogFileName = string.Empty;
			this.m_strLogFileExtension = string.Empty;
			this.m_strLogPathDirectory = string.Empty;
			this.m_blnUseHourlyLoggingFilename = true;
			this.m_blnTraceIsOn = false;
			this.m_blnConsoleIsOn = false;
		}
		private string GetLogFileName(string p_strWholeFileNameIN)
		{
			string text = string.Empty;
			try
			{
				text = this.StripExtension(p_strWholeFileNameIN);
				int num = text.LastIndexOf(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aw());
				if (num > 0)
				{
					text = text.Substring(checked(num + 1));
				}
			}
			catch (Exception expr_2C)
			{
				ProjectData.SetProjectError(expr_2C);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aY());
			}
			return text;
		}
		private string GetLogPathDirectory(string p_strWholeFileNameIN)
		{
			string text = string.Empty;
			try
			{
				text = p_strWholeFileNameIN;
				int num = text.LastIndexOf(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aw());
				if (num > 0)
				{
					text = text.Substring(0, num);
				}
			}
			catch (Exception expr_25)
			{
				ProjectData.SetProjectError(expr_25);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.ay());
			}
			return text;
		}
		private string StripExtension(string p_strFileNameIn)
		{
			string text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l();
			try
			{
				text = p_strFileNameIn;
				int num = text.LastIndexOf(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aS());
				if (num > 0)
				{
					text = text.Substring(0, num);
				}
			}
			catch (Exception expr_25)
			{
				ProjectData.SetProjectError(expr_25);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aZ());
			}
			return text;
		}
		private string GetExtension(string p_strFileNameIn)
		{
			string text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l();
			try
			{
				text = p_strFileNameIn;
				int num = text.LastIndexOf(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.aS());
				if (num > 0)
				{
					text = text.Substring(num);
				}
			}
			catch (Exception expr_24)
			{
				ProjectData.SetProjectError(expr_24);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.az());
			}
			return text;
		}
		public void DeleteLogFolder()
		{
			this.DeleteLogFolderA();
		}
		private void DeleteLogFolderA()
		{
			try
			{
				if (Directory.Exists(this.LogPathDirectory))
				{
					Directory.Delete(this.LogPathDirectory);
				}
			}
			catch (Exception expr_1A)
			{
				ProjectData.SetProjectError(expr_1A);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BA());
			}
		}
		public void DeleteLogFile()
		{
			this.DeleteLogFileA();
		}
		private void DeleteLogFileA()
		{
			try
			{
				File.Delete(this.WholeLogFilePathandName);
			}
			catch (Exception expr_0D)
			{
				ProjectData.SetProjectError(expr_0D);
				throw new Exception(<PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Ba());
			}
		}
		public void LogToFile(string p_strEventText)
		{
			this.LogToFileA(p_strEventText);
		}
		private void LogToFileA(string p_strEventText)
		{
			StreamWriter streamWriter = null;
			string path = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.l();
			try
			{
				if (this.m_blnLoggingIsEnabled)
				{
					path = this.WholeLogFilePathandName;
					if (!Directory.Exists(this.LogPathDirectory))
					{
						Directory.CreateDirectory(this.LogPathDirectory);
					}
					streamWriter = File.AppendText(path);
					streamWriter.WriteLine(Conversions.ToString(DateAndTime.Now) + <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BB() + p_strEventText);
					if (this.TraceIsOn)
					{
						Trace.WriteLine(Conversions.ToString(DateAndTime.Now) + <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BB() + p_strEventText);
					}
					if (this.ConsoleIsOn)
					{
						Console.WriteLine(Conversions.ToString(DateAndTime.Now) + <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BB() + p_strEventText);
					}
				}
			}
			catch (Exception expr_9B)
			{
				ProjectData.SetProjectError(expr_9B);
				ProjectData.ClearProjectError();
			}
			finally
			{
				try
				{
					if (this.m_blnLoggingIsEnabled && streamWriter != null)
					{
						streamWriter.Close();
					}
				}
				catch (Exception expr_BC)
				{
					ProjectData.SetProjectError(expr_BC);
					ProjectData.ClearProjectError();
				}
			}
		}
		public void LogToConsole(classLogging.MessageTypes p_intMessageType, string p_strMessage)
		{
			this.LogToConsoleA(p_intMessageType, p_strMessage);
		}
		private void LogToConsoleA(classLogging.MessageTypes p_intMessageType, string p_strMessage)
		{
			string text;
			if (p_intMessageType == classLogging.MessageTypes.e_intError)
			{
				text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Bb() + p_strMessage;
			}
			else
			{
				if (p_intMessageType == classLogging.MessageTypes.e_intInfo)
				{
					text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BC() + p_strMessage;
				}
				else
				{
					if (p_intMessageType == classLogging.MessageTypes.e_intSuccess)
					{
						text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.Bc() + p_strMessage;
					}
					else
					{
						text = p_strMessage;
					}
				}
			}
			if (this.TraceIsOn)
			{
				Trace.WriteLine(text);
			}
			if (this.ConsoleIsOn)
			{
				Console.WriteLine(text);
			}
		}
		public void LogRuntimeError(string p_strSource, string p_strMessage, string p_strStackTrace)
		{
			this.LogRuntimeErrorA(p_strSource, p_strMessage, p_strStackTrace);
		}
		private void LogRuntimeErrorA(string p_strSource, string p_strMessage, string p_strStackTrace)
		{
			string text = string.Empty;
			text = <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.BD() + p_strSource;
			text += <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.n();
			text += p_strMessage;
			text += <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.n();
			text += p_strStackTrace;
			text += <PrivateImplementationDetails>{30866905-2020-4195-BB80-BBCC195E985D}.n();
			this.LogToFile(text);
		}
	}
}
