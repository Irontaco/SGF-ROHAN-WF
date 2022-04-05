using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Model
{
    public class Client
    {

        private int _id;
        public int Id
        {
            get { return _id; } set { _id = value; } 
        }

        private string _names;
        public string Names { 
            get { return _names; }
            set { _names = value; } 
        }

        private string _surnames;

        public string Surnames
        {
            get { return _surnames; }
            set { _surnames = value; }
        }

        public string FullName
        {
            get
            {
                string FullName = Names + " " + Surnames;
                return FullName;
            }
        }

        public string Email;
        public int PhoneNumber;
        public RegisteredBusiness registeredBusiness; 
    }
}
