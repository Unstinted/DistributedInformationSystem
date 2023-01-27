using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class LocalPayment
    {
        public LocalPayment()
        {

        }
        public LocalPayment(Guid OrderInfo, DateTime PaymentDate, int AmountPaid, int CheckNumber, String BankName, int UnitPrice, int UnitSold, int TotalPurchasedPrice, Product productID)
        {
            this.OrderInfo = OrderInfo;
            this.PaymentDate = PaymentDate;
            this.CheckNumber = CheckNumber;
            this.AmountPaid = AmountPaid;
            this.BankName = BankName;
            this.UnitPrice = UnitPrice;
            this.UnitSold = UnitSold;
            this.TotalPurchasedPrice = TotalPurchasedPrice;
            this.productID = productID;
        }

        private Guid OrderInfo;

        public Guid OrderDetails
        {
            get { return OrderInfo; }
            set { OrderInfo = value; }
        }

        private DateTime PaymentDate;

        public DateTime OrderPayment
        {
            get { return PaymentDate; }
            set { PaymentDate = value; }
        }

        private Decimal AmountPaid;

        public Decimal payment
        {
            get { return AmountPaid; }
            set { AmountPaid = value; }
        }

        private int CheckNumber;

        public int CheckNo
        {
            get { return CheckNumber; }
            set { CheckNumber = value; }
        }

        private String BankName;

        public String Bankname
        {
            get { return BankName; }
            set { BankName = value; }
        }

        private Product productID;

        public Product product
        {
            get { return productID; }
            set { productID = value; }
        }

        private int UnitPrice;

        public int UPrice
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }

        private int UnitSold;

        public int USold
        {
            get { return UnitSold; }
            set { UnitSold = value; }
        }

        private int TotalPurchasedPrice;

        public int TPP
        {
            get { return TotalPurchasedPrice; }
            set { TotalPurchasedPrice = value; }
        }
        
    }
}
