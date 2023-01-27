using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Stock
    {
        public Stock()
        {

        }
        public Stock(int StockID, Guid Product, int EmployeeInfo, int QuantityInStock, DateTime StockDate, int StoreID)
        {
            this.StockID = StockID;
            this.EmployeeInfo = EmployeeInfo;
            this.QuantityInStock = QuantityInStock;
            this.StockDate = StockDate;
            this.StoreID = StoreID;
            this.Product = Product;
            
        }

        private Guid Product;

        public Guid product
        {
            get { return Product; }
            set { Product = value; }
        }
        

        private int StoreID;

        public int storeId
        {
            get { return StoreID; }
            set { StoreID = value; }
        }
        

        private int StockID;

        public int StockId
        {
            get { return StockID; }
            set { StockID = value; }
        }

        private int QuantityInStock;

        public int StockQuantity
        {
            get { return QuantityInStock; }
            set { QuantityInStock = value; }
        }

        private DateTime StockDate;

        public DateTime TheStockDate
        {
            get { return StockDate; }
            set { StockDate = value; }
        }

        private int EmployeeInfo;

        public int EmployeeDetail
        {
            get { return EmployeeInfo; }
            set { EmployeeInfo = value; }
        }
        

    }
}
