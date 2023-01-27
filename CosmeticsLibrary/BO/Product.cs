using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Product
    {
        public Product()
        {

        }
        public Product(Guid ProductCode, String ProductName, decimal SaleUnitPrice)
        {
            this.ProductCode = ProductCode;
            this.ProductName = ProductName;
            this.SaleUnitPrice = SaleUnitPrice;
        }
        public Product(String ProductName)
        {
            this.ProductName = ProductName;
        }

        public Product(Guid ProductCode, string ProductName)
        {
            // TODO: Complete member initialization
            this.ProductCode = ProductCode;
            this.ProductName = ProductName;
        }

        private Guid ProductCode;

        public Guid Productcode
        {
            get { return ProductCode; }
            set { ProductCode = value; }
        }

        private String ProductName;

        public String Productname
        {
            get { return ProductName; }
            set { ProductName = value; }
        }


        private decimal SaleUnitPrice;

        public decimal UnitSalesPrice
        {
            get { return SaleUnitPrice; }
            set { SaleUnitPrice = value; }
        }

        public override string ToString()
        {
            return this.Productname;
        }
    }
}
