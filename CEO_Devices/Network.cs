using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Net.NetworkInformation;

namespace CEO_Devices
{
    public class Network
    {
        public static  string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            if (nics.Count() == 0)
            {
                return "50465DB23E33";
            }
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } return sMacAddress.Substring(5);
        }
        public static String GetMacAddressKey()
        {
            String StrNetwork = Network.GetMACAddress();
            return StrNetwork.Substring(0, 3) + "-" + StrNetwork.Substring(3, 4);
        }
    }
}
