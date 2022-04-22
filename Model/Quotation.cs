using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Model
{

    [Serializable]
    public class Quotation
    {

        private int _quotationId;
        public int Id
        {
            get { return _quotationId; }
            set { _quotationId = value; }
        }

        private Client _client;
        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        private List<Product> _productsInvolved;
        public List<Product> ProductsInvolved
        {
            get { return _productsInvolved; }
            set { _productsInvolved = value; }
        }

        private DateTime _emissionDate;
        public DateTime EmissionDate
        {
            get { return _emissionDate; }
            set { _emissionDate = value; }
        }

        private float _totalPrice;
        public float TotalPrice { 
            get => _totalPrice; 
            set => _totalPrice = value; 
        }

        private float _netTotal;
        public float NetTotal { 
            get => _netTotal; 
            set => _netTotal = value; 
        }


        public Quotation()
        {

        }

    }


}
