using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace CEO_Devices
{
    public class CPU
    {
        public static String getCPUID()
        {
            String cpuid = "";
            try
            {
                ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
                ManagementObjectCollection mbsList = mbs.Get();
                foreach (ManagementObject tmpList in mbsList)
                {
                    cpuid = tmpList["ProcessorID"].ToString();
                }
                return cpuid.Substring(5);
            }
            catch (Exception) { return cpuid; }
        }
        public static String GetCPUKey()
        {
            String StrCPU = CPU.getCPUID().ToUpper();
            String tmpItem;
            tmpItem = StrCPU.Substring(0, 3) + "-" + StrCPU.Substring(3, 3) + "-" + StrCPU.Substring(6, 3);
           return tmpItem;
        }
    }
}
