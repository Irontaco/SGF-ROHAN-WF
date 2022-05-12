using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Model
{
    //Holds all runtime data.
    [Serializable]
    public class SessionData
    {

        //Data used for keeping backup information of session data.
        //Note: This is pretty bad!
        public DateTime SessionDate;

        //Name for the session data. Used for identification.
        public string SessionFileName;

        public Dictionary<int, Client> ClientData;
        public Dictionary<int, Product> ProductData;
        public Dictionary<int, Quotation> QuotationData;

        public SessionData()
        {
            ClientData = new Dictionary<int, Client>();
            ProductData = new Dictionary<int, Product>();
            QuotationData = new Dictionary<int, Quotation>();

            SessionDate = DateTime.Now;
        }



    }
}
