using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_TestScript
{
    public  class CEO_Registry
    {
        public void Write(String SoftwareName, String ProductKey, String Keygen)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(SoftwareName);
            key.SetValue("ProductKey", ProductKey);
            key.SetValue("SerialKey", Keygen);

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

    }
}
