using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEO_Authentication
{
    public class User
    {
        private String _Username;

        public String Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private String _Lastname;

        public String Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }

    }
}
