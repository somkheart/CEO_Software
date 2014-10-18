using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CEO_Utils;

namespace CEO_FingerLicense
{
    public class SoftwareKey
    {
        public static bool checkKey(String DealerID ,String SoftwareCode,String SerialKey)
        {
            String tmpSerialKey, ProductKey;
            String serialKeyResult;
            ProductKey = SoftwareKey.GetProductKey();
            tmpSerialKey = DealerID + ProductKey.Replace("-", "") + SoftwareCode.Substring(0, 5);
            tmpSerialKey = CEO_Utils.Encryption.Encrypt(tmpSerialKey).ToUpper().Substring(0, 18);
            serialKeyResult = tmpSerialKey.Substring(0, 5) + "-" + tmpSerialKey.Substring(5, 5) + "-" + tmpSerialKey.Substring(10, 5);
            return serialKeyResult.Equals(SerialKey);
        }
        //public static bool saveSerialKey(String SoftwareName,String DealerID, String SoftwareKey, String SerialKey)
        //{
        //    try
        //    {
        //        CEORegistry reg = new CEORegistry();
        //        reg.Write(SoftwareName, "DealerID", DealerID);
        //        reg.Write(SoftwareName, "SoftwareKey", SoftwareKey);
        //        reg.Write(SoftwareName, "SerialKey", SerialKey);
        //        return true;
        //    }
        //    catch
        //    {
        //        return true;
        //    }
        //}
        public static bool saveSerialKey(String SoftwareName,String DealerID,String SoftwareCode,String SerialKey)
        {
            try
            {
                CEORegistry reg = new CEORegistry();
                reg.Write(SoftwareName,"DealerID", DealerID);
                reg.Write(SoftwareName, "SoftwareKey", SoftwareCode);
                reg.Write(SoftwareName, "SerialKey", SerialKey);
                return true;
            }
            catch
            {
                return true;
            }
        }

        public static bool checkRegistedKey(String SoftwareName)
        {
            String DealerID;
            String SoftwareKey;
            String SerialKey;
            DealerID = GetDealerID(SoftwareName);
            SoftwareKey = GetSoftwareKey(SoftwareName);
            SerialKey=GetSerialKey(SoftwareName);
            return checkKey(DealerID, SoftwareName, SerialKey);
        }
        public static String GetDealerID(String SoftwareName)
        {
            CEORegistry reg = new CEORegistry();
            return reg.Read(SoftwareName, "DealerID");
        }
        public   static String GetSoftwareKey(String SoftwareName)
        {
            CEORegistry reg = new CEORegistry();
            return reg.Read(SoftwareName,"SoftwareKey");
        }
        public static String GetSerialKey(String SoftwareName)
        {
            CEORegistry reg = new CEORegistry();
            return reg.Read(SoftwareName,"SerialKey");
        }
        public static String GetProductKey()
        {
            String tmpProductKey = "";
            String tmpCPU = CEO_Devices.CPU.GetCPUKey();
            String tmpMac = CEO_Devices.Network.GetMacAddressKey();
            tmpProductKey=tmpCPU + "-" + tmpMac;
            return tmpProductKey;
        }
        public static String GetSerialKey(String SoftwareCode, String DealerID, String ProductKey)
        {
            String SerialKey;
            SerialKey = DealerID + ProductKey.Replace("-", "") + SoftwareCode.Substring(0, 5);
            SerialKey = CEO_Utils.Encryption.Encrypt(SerialKey).ToUpper().Substring(0, 18);
            return SerialKey.Substring(0, 5) + "-" + SerialKey.Substring(5, 5) + "-" + SerialKey.Substring(10, 5);
        }
    }
}
