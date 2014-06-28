using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_STORE
{
    class ModuleStructor
    {
        private String _ModuleName;

        public String ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }
        private String _ModuleType;

        public String ModuleType
        {
            get { return _ModuleType; }
            set { _ModuleType = value; }
        }
        private String _ModulePath;

        public String ModulePath
        {
            get { return _ModulePath; }
            set { _ModulePath = value; }
        }
    }
}
