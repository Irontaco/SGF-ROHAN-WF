using SGF_ROHAN_WF.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private float _ivaDifference;
        public float IvaDifference
        {
            get { return (TotalPrice - NetTotal); }
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

        public void AddNewEntryToProductEntries(int itemNo, Product product, int quantity, float discount, out Entry newEntry)
        {
            newEntry = new Entry(itemNo, product, quantity, discount);
            ProductEntries.Add(newEntry);

        }
        public void AddNewEntryToProductEntries(Product product, int quantity, float discount, out Entry newEntry)
        {
            newEntry = new Entry(this, product, quantity, discount);
            ProductEntries.Add(newEntry);

        }

        public void RemoveEntryFromProductEntries(int itemNo)
        {
            ProductEntries.RemoveAt(itemNo);
        }

        public void RemoveEntryFromProductEntries(Entry entry)
        {
            ProductEntries.Remove(entry);
        }

        public void RecalculatePrices()
        {

            this.NetTotal = 0;
            this.TotalPrice = 0;

            foreach (Entry entry in this.ProductEntries)
            {
                this.NetTotal += entry.FinalPrice;
            }

            this.TotalPrice = this.NetTotal + (this.NetTotal * (19f / 100));

        }

        public Entry GetEntryFromItemNumber(int itemNo)
        {
            if(ProductEntries.Count == 0)
            {
                return null;
            }
            try
            {
                foreach (Entry entry in ProductEntries)
                {
                    if (entry.ItemNumber == itemNo)
                    {
                        return entry;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            

            return null;

        }

    }

    public interface IQuotationRepository
    {

        Quotation GetQuotationFromId(int id);
        List<Quotation> GetAllQuotations();
        bool CreateQuotation(Quotation quo);
        bool DeleteQuotation(int id);
        bool UpdateQuotation(int id, Quotation updatedQuotationData);

    }


    public class Entry
    {

        public Quotation ParentQuotation;
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

        public Entry(Quotation parentQuo, Product rowProduct, int qty, float disc)
        {
            ParentQuotation = parentQuo;
            RowProduct = rowProduct;
            Quantity = qty;
            Discount = disc;
        }

        public void RemoveEntryFromQuotation()
        {
            ParentQuotation.RemoveEntryFromProductEntries(this);
        }

    }

}
