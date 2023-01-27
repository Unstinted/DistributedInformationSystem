using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class OnlinePayment
    {
        public OnlinePayment()
        {

        }
        public OnlinePayment(Guid OrderId, DateTime PayDate, Decimal AmtPaid, int CheckNum, String BankInfo, int UnitPrice, int UnitSold, int TotalPurchasedPrice, Guid productID)
        {
            this.OrderInfo = OrderId;
            this.PaymentDate = PayDate;
            this.CheckNumber = CheckNum;
            this.AmountPaid = AmtPaid;
            this.BankName = BankInfo;
            this.UnitPrice = UnitPrice;
            this.UnitSold = UnitSold;
            this.TotalPurchasedPrice = TotalPurchasedPrice;
            this.productID = productID;
        }

        private Guid productID;

        public Guid product
	    {
		get { return productID;}
		set { productID = value;}
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
