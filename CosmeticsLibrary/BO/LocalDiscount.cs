using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class LocalDiscount
    {

        public LocalDiscount()
        {

        }
        public LocalDiscount(int DiscountID, Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate) 
        {
            this.DiscountID = DiscountID;
            this.DiscountRate = DiscountRate;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.EmployeeID = EmployeeID;
            this.ProductInfo = ProductInfo;

        }


        private int StoreID;

        public int storeID
        {
            get { return StoreID; }
            set { StoreID = value; }
        }
        
        public LocalDiscount(int DiscountRate)
        {
            this.DiscountRate = DiscountRate;
        }

        public LocalDiscount(int DiscountID, int EmployeeID, Guid ProductInfo, DateTime StartDate, DateTime EndDate, int DiscountRate, int StoreID)
        {
            // TODO: Complete member initialization
            this.DiscountID = DiscountID;
            this.EmployeeID = EmployeeID;
            this.ProductInfo = ProductInfo;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.DiscountRate = DiscountRate;
            this.StoreID = StoreID;
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
