using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class LocalOrderDetails
    {
        public LocalOrderDetails()
        {

        }
        public LocalOrderDetails(Guid OrderID, Product Product, int Quantity, int UnitPrice)
        {
            this.OrderID = OrderID;
            this.Product = Product;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
        }


        private Guid OrderID;

        public Guid OrderIdentity
        {
            get { return OrderID; }
            set { OrderID = value; }
        }

        private Product Product;

        public Product ProductDetail
        {
            get { return Product; }
            set { Product = value; }
        }

        private int Quantity;

        public int OrderQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        private decimal UnitPrice;

        public decimal Price
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }

        public decimal Total
        {
            get { return Price * OrderQuantity; }
        }

    }
}
