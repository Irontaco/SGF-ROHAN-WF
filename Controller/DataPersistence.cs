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

        public DataPersistence()
        {
            if(DataSerializer.Load("clData") != null)
            {
                SavedData = DataSerializer.Load("clData");
                CurrentData = SavedData;

            }
            else
            {
                Console.WriteLine("No SavedData detected... Creating new file once we save!");
                CurrentData = new SessionData();
            }

        }

        public List<Client> FetchClientsFromSavedData()
        {
            if(SavedData == null)
            {
                Console.WriteLine("we were given null data!");
                return null;
            }

            List<Client> clientList = new List<Client>();

            foreach(Client client in SavedData.ClientData.Values)
            {
                clientList.Add(client);
            }

            return clientList;
        }

    }
}
