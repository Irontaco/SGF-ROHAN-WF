using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF_ROHAN_WF.Model
{
    public class Quotation
    {

        private int _quotationId;
        public int Id
        {
            get { return _quotationId; }
            set { _quotationId = value; }
        }

        public List<Product> ProductsToCheck;

        public DateTime EmissionDate;

        public float TotalPrice;
        public float NetTotal;
        public float IvaPercentage = 19.0f;


        public Quotation()
        {

        }

    }


}
