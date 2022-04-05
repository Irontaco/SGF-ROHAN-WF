using System.Collections.Generic;

namespace SGF_ROHAN_WF.Model
{
    public class Product
    {

        private int _id;

        public int Id { get
            {
                return _id;
            }
            set { _id = value; }
        
        }

        private string _productname;
        public string ProductName { 
            get { return _productname; } 
            set { _productname = value;} 
        }

        private string _productdescription;
        public string ProductDescription
        {
            get { return _productdescription; } 
            set { _productdescription = value;} 
        }

        private float _unitprice;  
        public float UnitPrice { 
            get { return _unitprice; } 
            set { _unitprice = value; } 
        }

        public List<object> AdditionalProductDetails;

        public Product(string productName, string productDescription, float unitPrice)
        {
            this.ProductName = productName;
            this.ProductDescription = productDescription;
            this.UnitPrice = unitPrice;
        }

    
    
    }
}