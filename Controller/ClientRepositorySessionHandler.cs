using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_ROHAN_WF.Controller
{
    public class ClientRepositorySessionHandler : IClientRepository
    {
        private readonly DataPersistence DataPersistence;
        private Dictionary<int, Client> ClientData;

        public ClientRepositorySessionHandler(DataPersistence dataPers)
        {
            DataPersistence = dataPers;
            ClientData = DataPersistence.CurrentData.ClientData;

            
        }
        
        public bool OnClientDataChanged()
        {
            return DataPersistence.CommitChanges();
        }



        public bool CreateClient(Client client)
        {
            if(client != null)
            {
                client.Id = ClientData.Count + 1;

                ClientData.Add(client.Id, client);

                return OnClientDataChanged();
            }

            return false;

        }

        public bool DeleteClient(int id)
        {
            if(id > 0)
            {
                try
                {
                    ClientData[id].IsDeleted = true;
                    return OnClientDataChanged();

                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("We've been given wrong data as the dictionary entry.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un cliente válido para eliminar.");
                return false;
            }


        }

        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();
            try
            {
                foreach (KeyValuePair<int, Client> clientEntry in ClientData)
                {
                    clients.Add(clientEntry.Value);
                }

                return clients;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return clients;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return clients;

            }
        }

        public Client GetClientFromId(int id)
        {
            foreach (KeyValuePair<int, Client> KVP in ClientData)
            {
                if (KVP.Value.Id == id)
                {
                    return KVP.Value;
                }
            }

            return null;
        }


        //Returns the client that matches the full name.
        //Since we never really select clients through partial matches, this is ok.
        //We also never will return null, given that selection is done through a ListBox.
        //Therefore, names are always picked exactly from the entries that exist in our ClientData.
        //Unless something has gone terribly wrong in that. Yeah.
        public Client GetClientFromName(string name)
        {
            foreach(KeyValuePair<int, Client> KVP in ClientData)
            {
                if(KVP.Value.FullName == name)
                {
                    return KVP.Value;
                }
            }

            return null;

        }

        /// <summary>
        /// Updates a specified Client object. An previous ID and a new Client object must be supplied.
        /// </summary>
        /// <param name="id">Client ID to update into.</param>
        /// <param name="updatedClientData">The updated client data to replace the entry with.</param>
        /// <returns></returns>
        public bool UpdateClient(int id, Client updatedClientData)
        {
            try
            {
                foreach(KeyValuePair<int, Client> KVP in ClientData)
                {
                    if(KVP.Key == id)
                    {
                        ClientData[KVP.Key] = updatedClientData;
                        return OnClientDataChanged();
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El cliente entregado tiene información inválida.");
                return false;
            }

            //No matches.
            //TODO: This function shouldn't really ever trigger without having checked if the ID is valid first.
            return false;
        }
    }
}
