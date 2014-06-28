using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_Devices.SmartCard
{
   public interface ISmartCardReader
	{
		void SelectReader(string readerName);
		string[] GetReaderLists();
		bool GetCardStatus();
		string GetSerialNumber();
		bool Connect();
		void Disconnect();
		string GetCardAtrString();
		int SmartCardExchangeAPDU(SmartCardAPDU apdu);
		int GetLastError();
		string GetMessage(int error);
	}
}
