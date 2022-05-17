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

        //It's important that we don't keep actual references of the Client/Product objects in here.
        //If they're deleted, we don't want to gather Quotation objects with broken object references.
        //All operations that require these to be gathered need to make new objects.
        private Client _client;
        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        private List<Entry> _productEntries;
        public List<Entry> ProductEntries
        {
            get { return _productEntries; }
            set { _productEntries = value; }
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

        private string _offervalidfor;
        public string OfferValidFor
        {
            get => _offervalidfor;
            set => _offervalidfor = value;
        }

        public Quotation()
        {
            ProductEntries = new List<Entry>();

        }

        public bool AddNewEntryFromProductData(Product rowProduct, int qty, float disc, bool addToIndex, out Entry generatedEntry)
        {
            try
            {
                generatedEntry = new Entry(ProductEntries.Count + 1, rowProduct, qty, disc);

                if (addToIndex && AddEntryToIndex(generatedEntry))
                {
                    return true;
                }
                else if (addToIndex && !AddEntryToIndex(generatedEntry))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                generatedEntry = null;
                return false;
            }
        }

        public bool AddEntryToIndex(Entry newEntry)
        {
            if(newEntry == null)
            {
                return false;
            }
            else
            {
                ProductEntries.Add(newEntry);
                return true;
            }
        }

        public bool RemoveEntryFromIndex(int itemNo)
        {
            if(itemNo == 0 || itemNo < 0 || ProductEntries[itemNo] == null)
            {
                return false;
            }

            ProductEntries.RemoveAt(itemNo);
            return true;

        }

    }

    public class Entry
    {
        public int ItemNumber;
        public Product RowProduct;
        public int Quantity;
        public float Discount;
        public float TotalPrice
        {
            get => Convert.ToInt32(RowProduct.UnitPrice) * Quantity;
        }
        public float FinalPrice
        {
            get => TotalPrice - (TotalPrice * (Discount / 100));
        }

        public Entry(int itemNo, Product rowProduct, int qty, float disc)
        {
            ItemNumber = itemNo;
            RowProduct = rowProduct;
            Quantity = qty;
            Discount = disc;
        }

    }

}
