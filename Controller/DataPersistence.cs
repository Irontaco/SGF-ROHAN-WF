using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Controller
{
    public class DataPersistence
    {
        public SessionData CurrentData;
        public SessionData SavedData;

        public ClientRepositorySessionHandler ClientRepository;
        public QuotationRepositorySessionHandler QuotationRepository;

        public DataPersistence()
        {
            
            if(DataSerializer.LoadSessionData("sessionData") != null)
            {
                SavedData = DataSerializer.LoadSessionData("sessionData");
                CurrentData = SavedData;

            }
            else
            {
                Console.WriteLine("No SavedData detected... Creating new file once we save!");
                SavedData = CurrentData = new SessionData();
            }

            ClientRepository = new ClientRepositorySessionHandler(this);
            QuotationRepository = new QuotationRepositorySessionHandler(this);

        }

        public bool CommitChanges()
        {
            if (DataSerializer.SaveSessionData(CurrentData, "sessionData"))
            {
                return true;
            }

            return false;
        }

    }
}
