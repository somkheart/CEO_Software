using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_FingerScan.DataModel
{
    class Setting
    {
        private String folderPath;
        private String widht;

        public String Widht
        {
            get { return widht; }
            set { widht = value; }
        }
        private String height;

        public String Height
        {
            get { return height; }
            set { height = value; }
        }
        public  String FolderPath
        {
            get { return folderPath; }
            set { folderPath = value; }
        }
       
    
    }
}
