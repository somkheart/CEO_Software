using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_Configuration
{
    class CoreConfig
    {
        private String _ConnectionString;

        public String ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }
    }
}
