using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using CEO_Devices;
using System.Windows.Forms;

namespace CEO_FingerLicense
{
    public static class License
    {
        const String Software = "CEOSOFTWARE";
        private struct Serial
        {
            public String DealerID;
            public String CPUID;
            public String MacAddress;
        }
        private static bool Actived(String Code)
        {
            return true;
        }
        private static String GetActiveCode(String CPUID,String MacAddress,String DealerID)
        {
            String tmpStr=EncodeSerial(CPUID, MacAddress, DealerID);
            return tmpStr;
        }
        public static string GetSerialKey(String ProductKey,String DealerID,String SoftwareCode)
        {
            String SerialKey;
            SerialKey = DealerID + ProductKey.Replace("-", "");
            SerialKey = CEO_Utils.Encryption.Encrypt(SerialKey).ToUpper().Substring(0, 18);
            return SerialKey.Substring(0, 5) + "-" + SerialKey.Substring(5, 5) + "-" + SerialKey.Substring(10, 5);
        }
        public static string GetSerialKey(String DealerID)
        {
            String tmpCPU = CEO_Devices.CPU.GetCPUKey();
            String tmpMac = CEO_Devices.Network.GetMacAddressKey();
            String ProductKey = tmpCPU + "-" + tmpMac;
            String SerialKey;
            SerialKey = DealerID + ProductKey.Replace("-", "");
            SerialKey = CEO_Utils.Encryption.Encrypt(SerialKey).ToUpper().Substring(0, 18);
            return SerialKey.Substring(0, 5) + "-" + SerialKey.Substring(5, 5) + "-" + SerialKey.Substring(10, 5);
        }
        public static String GetProductKey()
        {
            String tmpCPU = CEO_Devices.CPU.GetCPUKey();
            String tmpMac = CEO_Devices.Network.GetMacAddressKey();
            return tmpCPU + "-" + tmpMac;
        }
        private static  String  EncodeSerial(String CPUID,String MacAddress,String DealerID)
        {
            String tmpSerailKey;
            tmpSerailKey = (DealerID+CPUID.Substring(5) + MacAddress.Substring(5)).Replace("-", "");
            tmpSerailKey = CEO_Utils.Encryption.Encrypt(tmpSerailKey).ToUpper().Substring(0, 18);
            return tmpSerailKey.Substring(0, 5) + "-" + tmpSerailKey.Substring(5,5)+"-"+tmpSerailKey.Substring(10,5);
        }
        public static void SaveRegisKey(String ProgramName,String SerialKey,String DealerID)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(ProgramName);
            key.SetValue("DealerID", DealerID);
            key.SetValue("SerialKey", SerialKey);
            key.Close();
        }
        public static void SaveRegistryValue(String ProgramName, String KeyName, String Value)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(ProgramName);
            key.SetValue(KeyName, Value);
            key.Close();
        }
        public static bool isExistKey(String ProgramName)
        {
            Microsoft.Win32.RegistryKey tmpRegisterKey;
            tmpRegisterKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(ProgramName);
            return tmpRegisterKey != null;

        }
        public static String GetRegistryValue(String ProgramName, String KeyName)
        {
            try
            {
                String tmpStr;
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(ProgramName);
                tmpStr = key.GetValue(KeyName).ToString();
                key.Close();
                return tmpStr;
            }
            catch
            {
                String SoftwareName;
                SoftwareName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
                return "";
            }
        }
        public static String GetRegisKey(String ProgramName,String KeyName)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(ProgramName);
            String tmpKey = key.GetValue(KeyName).ToString();
            key.Close();
            return tmpKey;
        }
        public static String GetProductDealerID(String ProgramName)
        {
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(ProgramName);
                String tmpKey = key.GetValue("DealerID").ToString();
                key.Close();
                return tmpKey;
            }
            catch
            {
                return "";
            }
        }
        public static String GetProductSerialKey(String ProgramName)
        {
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(ProgramName);
                String tmpKey = key.GetValue("SerialKey").ToString();
                key.Close();
                return tmpKey;
            }
            catch
            {
                return "";
            }
        }

    }
}
