using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Model
{

    [Serializable]
    public class Client
    {

        private bool _isDeleted;
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

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

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _registeredBusiness;
        public string RegisteredBusiness
        {
            get { return _registeredBusiness; }
            set { _registeredBusiness = value; }
        }

    }

    public interface IClientRepository
    {

        Client GetClientFromId(int id);
        Client GetClientFromName(string name);
        List<Client> GetAllClients();
        bool CreateClient(Client client);
        bool DeleteClient(int id);
        bool UpdateClient(int id, Client updatedClientData);

    }
}
