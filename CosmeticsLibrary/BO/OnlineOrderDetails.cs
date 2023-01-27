using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class OnlineOrderDetails 
    {
        public OnlineOrderDetails()
        {

        }
        public OnlineOrderDetails(Guid IntOrderID, Guid Product, int Quantity, Decimal UnitPrice)
        {
            this.IntOrderID = IntOrderID;
            this.Product = Product;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
        }


        private Guid IntOrderID;

        public Guid OrderIdentity
        {
            get { return IntOrderID; }
            set { IntOrderID = value; }
        }

        private Guid Product;

        public Guid ProductDetail
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

        private Decimal UnitPrice;

        public Decimal Price
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }

    }
}
