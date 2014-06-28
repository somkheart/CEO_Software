using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CEO_Devices.SmartCard
{
    public class CEO_Configurations
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string readerName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string folder;
        public bool showProgress;
        public bool loadPhoto;
    }
}
