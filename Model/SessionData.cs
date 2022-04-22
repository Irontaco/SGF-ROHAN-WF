using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Model
{
    //Holds all locally-stored data at runtime.
    [Serializable]
    public class SessionData
    {

        public Dictionary<int, Client> ClientData = new Dictionary<int, Client>();


    }
}
