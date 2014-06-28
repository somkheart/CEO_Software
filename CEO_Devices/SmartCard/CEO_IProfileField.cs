using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_Devices.SmartCard
{
    public interface ISmartCardProfile
    {
        int StartApplet(ISmartCardReader reader, out string version);
        int LoadProfile(object ctl);
        int LoadPhoto(object ctl);
        string GetFieldValue(CEO_ProfileField field);
        string GetNationalID();
        byte[] GetPhoto();
    }
}
