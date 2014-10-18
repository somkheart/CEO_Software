using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_FingerLicense
{
    public  class CEO_Registry
    {
        public void Write(String SoftwareName,String DealerID,String ProductKey, String Keygen)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(SoftwareName);
            key.SetValue("ProductKey", ProductKey);
            key.SetValue("SerialKey", Keygen);
            key.SetValue("DealerID", DealerID);

        }
        public String GetProductKey(String SoftwareName)
        {
            Microsoft.Win32.RegistryKey key;
            String tmpValue;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SoftwareName);
            tmpValue = key.GetValue("ProductKey").ToString();
            return tmpValue;
        }
        public String GetSerialKey(String SoftwareName)
        {
            Microsoft.Win32.RegistryKey key;
            String tmpValue;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SoftwareName);
            tmpValue = key.GetValue("SerialKey").ToString();
            return tmpValue;
        }
        public String GetDealerID(String SoftwareName)
        {
            Microsoft.Win32.RegistryKey key;
            String tmpValue;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SoftwareName);
            tmpValue = key.GetValue("DealerID").ToString();
            return tmpValue;
        }
        public  bool checkKey(String DealerID, String SoftwareCode, String SerialKey)
        {
            String tmpSerialKey, ProductKey;
            String serialKeyResult;
            ProductKey = SoftwareKey.GetProductKey();
            tmpSerialKey = DealerID + ProductKey.Replace("-", "") + SoftwareCode.Substring(0, 5);
            tmpSerialKey = CEO_Utils.Encryption.Encrypt(tmpSerialKey).ToUpper().Substring(0, 18);
            serialKeyResult = tmpSerialKey.Substring(0, 5) + "-" + tmpSerialKey.Substring(5, 5) + "-" + tmpSerialKey.Substring(10, 5);
            return serialKeyResult.Equals(SerialKey);
        }

    }
}
