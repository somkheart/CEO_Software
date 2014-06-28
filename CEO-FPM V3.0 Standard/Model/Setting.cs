using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_FPM_V3._0_Standard.Model
{
    class Setting
    {
        private int _Widht;

        public int Widht
        {
            get { return _Widht; }
            set { _Widht = value; }
        }
        private int _Height;

        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        private String _FolderPath;

        public String FolderPath
        {
            get { return _FolderPath; }
            set { _FolderPath = value; }
        }

    }
}
