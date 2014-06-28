using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_Devices.SmartCard
{
    public class SmartCardAPDU
    {
        public byte CLA;
        public byte INS;
        public byte P1;
        public byte P2;
        public byte Lc;
        public byte Le;
        public ushort status;
        public byte[] dataIn = new byte[255];
        public byte[] dataOut = new byte[255];
        public SmartCardAPDU()
        {
            this.CLA = 0;
            this.INS = 0;
            this.P1 = 0;
            this.P2 = 0;
            this.Lc = 0;
            this.Le = 0;
            this.status = 0;
            Array.Clear(this.dataIn, 0, 255);
            Array.Clear(this.dataOut, 0, 255);
        }
    }
}
