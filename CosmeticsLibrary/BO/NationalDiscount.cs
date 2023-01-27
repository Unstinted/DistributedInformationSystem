using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class NationalDiscount 
    {
        public NationalDiscount()
        {

        }

        public NationalDiscount(int DiscountID, Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate) 
        {
            this.DiscountID = DiscountID;
            this.DiscountRate = DiscountRate;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.EmployeeID = EmployeeID;
            this.ProductInfo = ProductInfo;
        }

        public NationalDiscount(int DiscountRate)
        {
            this.DiscountRate = DiscountRate;
        }

        private int DiscountID;

        public int discount
        {
            get { return DiscountID; }
            set { DiscountID = value; }
        }

        private Guid ProductInfo;

        public Guid ProductDetail
        {
            get { return ProductInfo; }
            set { ProductInfo = value; }
        }

        private int DiscountRate;

        public int Rate
        {
            get { return DiscountRate; }
            set { DiscountRate = value; }
        }

        private DateTime StartDate;

        public DateTime Startdate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }

        private DateTime EndDate;

        public DateTime Enddate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }

        private int EmployeeID;

        public int EmpD
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
    }
}
