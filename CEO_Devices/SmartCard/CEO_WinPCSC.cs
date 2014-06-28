using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CEO_Devices.SmartCard
{
    public class CEO_WinPCSC : ISmartCardReader
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct SCARD_READERSTATE
        {
            internal string szReader;
            internal IntPtr pvUserData;
            internal uint dwCurrentState;
            internal uint dwEventState;
            internal uint cbAtr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.U1)]
            internal byte[] rgbAtr;
        }
        [StructLayout(LayoutKind.Sequential)]
        internal class SCARD_IO_REQUEST
        {
            internal uint dwProtocol;
            internal uint cbPciLength;
            public SCARD_IO_REQUEST()
            {
                this.dwProtocol = 0u;
            }
        }
        private string activeReader;
        private IntPtr handleContext;
        private IntPtr handleCard;
        private uint activeProtocol;
        public CEO_WinPCSC()
        {
            this.handleContext = IntPtr.Zero;
            this.handleCard = IntPtr.Zero;
            this.activeReader = string.Empty;
            CEO_WinPCSC.SCardEstablishContext(2u, IntPtr.Zero, IntPtr.Zero, out this.handleContext);
        }
        ~CEO_WinPCSC()
        {
            if (this.handleCard != IntPtr.Zero)
            {
                CEO_WinPCSC.SCardDisconnect(this.handleCard, 0u);
            }
            if (this.handleContext != IntPtr.Zero)
            {
                CEO_WinPCSC.SCardReleaseContext(this.handleContext);
            }
        }
        public int GetLastError()
        {
            return 0;
        }
        public string GetMessage(int errorCode)
        {
            return string.Empty;
        }
        public string[] GetReaderLists()
        {
            char[] separator = new char[]
			{
				Convert.ToChar(0)
			};
            string[] result = new string[0];
            IntPtr zero = IntPtr.Zero;
            uint num = 4294967295u;
            int num2 = CEO_WinPCSC.SCardListReaderGroups(this.handleContext, ref zero, ref num);
            if (num2 != 0)
            {
                return result;
            }
            string text = Marshal.PtrToStringAuto(zero, (int)(num - 2u));
            string[] array = text.Split(separator);
            num2 = CEO_WinPCSC.SCardFreeMemory(this.handleContext, zero);
            IntPtr zero2 = IntPtr.Zero;
            uint num3 = 4294967295u;
            num2 = CEO_WinPCSC.SCardListReaders(this.handleContext, array[0], ref zero2, ref num3);
            if (num2 != 0)
            {
                return result;
            }
            text = Marshal.PtrToStringAuto(zero2, (int)(num3 - 2u));
            result = text.Split(separator);
            num2 = CEO_WinPCSC.SCardFreeMemory(this.handleContext, zero2);
            return result;
        }
        public void SelectReader(string readerName)
        {
            this.activeReader = readerName;
        }
        public bool GetCardStatus()
        {
            CEO_WinPCSC.SCARD_READERSTATE[] array = new CEO_WinPCSC.SCARD_READERSTATE[1];
            array[0].szReader = this.activeReader;
            array[0].pvUserData = IntPtr.Zero;
            array[0].dwCurrentState = 0u;
            array[0].dwEventState = 0u;
            array[0].cbAtr = 0u;
            array[0].rgbAtr = null;
            int num = CEO_WinPCSC.SCardGetStatusChange(this.handleContext, 0u, array, 1u);
            bool result = false;
            if (num == 0 && (array[0].dwEventState & 32u) > 0u)
            {
                result = true;
            }
            return result;
        }
        public bool Connect()
        {
            if (this.handleCard != IntPtr.Zero)
            {
                CEO_WinPCSC.SCardDisconnect(this.handleCard, 0u);
            }
            this.handleCard = IntPtr.Zero;
            uint dwShareMode = 2u;
            uint dwPreferredProtocols = 3u;
            uint num = 0u;
            if (CEO_WinPCSC.SCardConnect(this.handleContext, this.activeReader, dwShareMode, dwPreferredProtocols, out this.handleCard, out num) == 0)
            {
                this.activeProtocol = num;
                return true;
            }
            return false;
        }
        public void Disconnect()
        {
            CEO_WinPCSC.SCardDisconnect(this.handleCard, 0u);
            this.handleCard = IntPtr.Zero;
        }
        public string GetSerialNumber()
        {
            bool flag = false;
            string result = string.Empty;
            if (this.handleCard == IntPtr.Zero)
            {
                if (!this.Connect())
                {
                    return string.Empty;
                }
                flag = true;
            }
            uint dwAttrId = 65795u;
            IntPtr zero = IntPtr.Zero;
            uint len = 4294967295u;
            int num = CEO_WinPCSC.SCardGetAttrib(this.handleCard, dwAttrId, ref zero, ref len);
            if (flag)
            {
                this.Disconnect();
            }
            if (num == 0)
            {
                result = Marshal.PtrToStringAnsi(zero, (int)len);
                CEO_WinPCSC.SCardFreeMemory(this.handleContext, zero);
            }
            return result;
        }
        public string GetCardAtrString()
        {
            bool flag = false;
            string result = string.Empty;
            if (this.handleCard == IntPtr.Zero)
            {
                if (!this.Connect())
                {
                    return string.Empty;
                }
                flag = true;
            }
            uint dwAttrId = 590595u;
            IntPtr source = new IntPtr(0);
            uint num = 4294967295u;
            int num2 = CEO_WinPCSC.SCardGetAttrib(this.handleCard, dwAttrId, ref source, ref num);
            if (flag)
            {
                CEO_WinPCSC.SCardDisconnect(this.handleCard, 0u);
            }
            if (num2 == 0)
            {
                byte[] array = new byte[num];
                Marshal.Copy(source, array, 0, (int)num);
                StringBuilder stringBuilder = new StringBuilder("");
                int num3 = 0;
                while ((long)num3 < (long)((ulong)num))
                {
                    stringBuilder.Append(array[num3].ToString("X2"));
                    num3++;
                }
                result = stringBuilder.ToString();
            }
            return result;
        }
        public int SmartCardExchangeAPDU(SmartCardAPDU apdu)
        {
            byte[] array = new byte[(int)(apdu.Lc + 5)];
            array[0] = apdu.CLA;
            array[1] = apdu.INS;
            array[2] = apdu.P1;
            array[3] = apdu.P2;
            array[4] = ((apdu.Lc > 0) ? apdu.Lc : apdu.Le);
            if (apdu.Lc > 0)
            {
                Array.Copy(apdu.dataIn, 0, array, 5, (int)apdu.Lc);
                array[4] = apdu.Lc;
            }
            else
            {
                array[4] = apdu.Le;
            }
            IntPtr pciT = CEO_WinPCSC.GetPciT0();
            uint num = 257u;
            byte[] array2 = new byte[num];
            CEO_WinPCSC.SCARD_IO_REQUEST sCARD_IO_REQUEST = new CEO_WinPCSC.SCARD_IO_REQUEST();
            sCARD_IO_REQUEST.cbPciLength = 255u;
            int num2 = CEO_WinPCSC.SCardTransmit(this.handleCard, pciT, array, (uint)array.Length, null, array2, ref num);
            if (num2 == 0)
            {
                Array.Copy(array2, 0L, apdu.dataOut, 0L, (long)((ulong)(num - 2u)));
                apdu.status = (ushort)array2[(int)((UIntPtr)(num - 2u))];
                apdu.status = (ushort)(apdu.status << 8);
                apdu.status += (ushort)array2[(int)((UIntPtr)(num - 1u))];
            }
            return num2;
        }
        [DllImport("WINSCARD.DLL")]
        internal static extern int SCardEstablishContext(uint dwScope, IntPtr pvReserved1, IntPtr pvReserved2, out IntPtr phContext);
        [DllImport("WINSCARD.DLL")]
        internal static extern int SCardReleaseContext(IntPtr hContext);
        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern int SCardListReaders(IntPtr hContext, string mszGroups, ref IntPtr pmszReaders, ref uint pcchReaders);
        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern int SCardListReaderGroups(IntPtr hContext, ref IntPtr pmszGroups, ref uint pcchGroups);
        [DllImport("WINSCARD.DLL")]
        internal static extern int SCardFreeMemory(IntPtr hContext, IntPtr pvMem);
        [DllImport("WINSCARD.DLL")]
        internal static extern int SCardDisconnect(IntPtr hCard, uint dwDisposition);
        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern int SCardGetStatusChange(IntPtr hContext, uint dwTimeout, [In] [Out] CEO_WinPCSC.SCARD_READERSTATE[] rgReaderStates, uint cReaders);
        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern int SCardConnect(IntPtr hContext, string szReader, uint dwShareMode, uint dwPreferredProtocols, out IntPtr phCard, out uint pdwActiveProtocol);
        [DllImport("WINSCARD.DLL")]
        internal static extern int SCardGetAttrib(IntPtr hCard, uint dwAttrId, ref IntPtr pbAttr, ref uint pcbAttrLen);
        [DllImport("WINSCARD.DLL")]
        internal static extern int SCardTransmit(IntPtr hCard, IntPtr pioSendPci, [In] byte[] pbSendBuffer, uint cbSendLength, CEO_WinPCSC.SCARD_IO_REQUEST pioRecvPci, [In] [Out] byte[] pbRecvBuffer, ref uint pcbRecvLength);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("kernel32.dll")]
        internal static extern void FreeLibrary(IntPtr handle);
        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetProcAddress(IntPtr handle, string procName);
        private static IntPtr GetPciT0()
        {
            IntPtr handle = CEO_WinPCSC.LoadLibrary("winscard.dll");
            IntPtr procAddress = CEO_WinPCSC.GetProcAddress(handle, "g_rgSCardT0Pci");
            CEO_WinPCSC.FreeLibrary(handle);
            return procAddress;
        }
    }
}
