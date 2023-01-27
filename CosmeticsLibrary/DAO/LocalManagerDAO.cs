using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.DAO
{
    public class LocalManagerDAO : SaleStaffDAO
    {
       
        public Employee Authenticating(string Username, string Password)
        {
            Employee emp = null;
            String query  = "select e.Employee_ID, e.Name, e.Store_ID, s.Street_Address from Employee e, store s " +
           " Where e.store_id = s.Store_ID and e.Username = '"+Username+"' and e.Passwd = '"+Password+"'and e.Job_ID = 110 ";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            Console.WriteLine(query);
            if (sd.Read())
            {
                Console.WriteLine(sd.GetInt32(0));
                emp = new Employee();
                emp.ID = sd.GetInt32(0);
                emp.Name = sd.GetString(1);
                emp.store = sd.GetInt32(2);
                emp.street = sd.GetString(3);

            }
            return emp;
        }

        //Set Local Discount
        public void SetDiscount(Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate, int storeId)
        {
            String query = "insert into LocalDiscount(ProductCode, Employee_ID, DiscountStartDate, DiscountEndDate, DiscountRate,  Store_ID) values ('" + ProductInfo + "', '" + EmployeeID + "', '" + StartDate + "', '" + EndDate + "', '" + DiscountRate + "', '" + storeId + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

      

        //Generate report of order daily
        public List<LocalOrderDetails> GenerateProductReportDaily(DateTime orderDate, int storeId)
        {
            string query = "SELECT LocalOrder.OrderID, ProductCode, Quantity, Unitprice FROM LocalOrder, LocalOrderDetails	WHERE LocalOrder.OrderID = LocalOrderDetails.OrderID AND Store_ID = '" + storeId + "' and OrderDate = '" + orderDate.ToString("yyyy-MM-dd") + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<LocalOrderDetails> list = new List<LocalOrderDetails>();
            while (sd.Read())
            {
                LocalOrderDetails lod = new LocalOrderDetails { OrderIdentity = sd.GetGuid(0), ProductDetail = GetProduct(sd.GetGuid(1)), OrderQuantity = sd.GetInt32(2), Price = sd.GetDecimal(3) };
                list.Add(lod);
            }
            return list;
        }

        //Get Generate report of order weekly
        public List<LocalOrderDetails> GenerateProductReportWeekly(DateTime orderDate, DateTime OrderD, int storeId)
        {
            string query = "SELECT LocalOrder.OrderID, ProductCode, Quantity, Unitprice FROM LocalOrder, LocalOrderDetails	WHERE LocalOrder.OrderID = LocalOrderDetails.OrderID AND Store_ID = '" + storeId + "' and OrderDate between '" + OrderD.ToString("yyyy-MM-dd") + "' and '" + OrderD.ToString("yyyy-MM-dd") + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<LocalOrderDetails> list = new List<LocalOrderDetails>();
            while (sd.Read())
            {
                LocalOrderDetails lod = new LocalOrderDetails { OrderIdentity = sd.GetGuid(0), ProductDetail = GetProduct(sd.GetGuid(1)), OrderQuantity = sd.GetInt32(2), Price = sd.GetDecimal(3) };
                list.Add(lod);
            }
            return list;
        }

        //Generate Report for Stock
        public List<Stock> GenerateStockReportDaily(int StoreId, DateTime stockDate)
        {
            string query = "select Product.ProductCode, Stock.StockID, Product.Store_ID, Stock.QuantityInStock, Stock.Employee_ID from Product, Stock where Product.Store_ID = Stock.Store_ID and Product.ProductCode = Stock.ProductCode and Stock.Store_ID = '"+StoreId+"' and Stock.StockDate '"+stockDate+"'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<Stock> stocklist = new List<Stock>();
                while (sd.Read())
                {
                    Stock st = new Stock { product = sd.GetGuid(0), StockId = sd.GetInt32(1), storeId = sd.GetInt32(2), StockQuantity = sd.GetInt32(3), EmployeeDetail = sd.GetInt32(4) };
                    stocklist.Add(st);
                }
            return stocklist;
        }

        //Generate Report for Stock
        public List<Stock> GenerateStockReportWeekly(int StoreId, DateTime stockDate, DateTime Stockdate)
        {
            string query = "select Product.ProductCode, Stock.StockID, Product.Store_ID, Stock.QuantityInStock, Stock.Employee_ID from Product, Stock where Product.Store_ID = Stock.Store_ID and Product.ProductCode = Stock.ProductCode and Stock.Store_ID = '" + StoreId + "' and Stock.StockDate  between '" + stockDate + "' and '" + Stockdate + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<Stock> stocklist = new List<Stock>();
            while (sd.Read())
            {
                Stock st = new Stock { product = sd.GetGuid(0), StockId = sd.GetInt32(1), storeId = sd.GetInt32(2), StockQuantity = sd.GetInt32(3), EmployeeDetail = sd.GetInt32(4) };
                stocklist.Add(st);
            }
            return stocklist;
        }


        //Generate Payment Report
        public List<LocalPayment> GenerateLocalPayDaily(DateTime paymentDate, int Store)
        {
            string query = "select LocalOrderDetails.OrderID, LocalPayment.AmountPaid, LocalPayment.CheckNumber, LocalPayment.BankName from LocalPayment, LocalOrderDetails where LocalOrderDetails.OrderID = LocalPayment.OrderID and LocalPayment.Store_ID = '" + Store + "' and LocalPayment.PaymentDate = '" + paymentDate + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<LocalPayment> list = new List<LocalPayment>();
            while (sd.Read())
            {
                LocalPayment pay = new LocalPayment { OrderDetails = sd.GetGuid(0), payment = sd.GetDecimal(1), CheckNo = sd.GetInt32(2), Bankname = sd.GetString(3) };
                list.Add(pay);
            }
            return list;
        }

        public List<LocalPayment> GenerateLocalPayWeekly(DateTime paymentDate, DateTime PayDay, int Store)
        {
            string query = "select LocalOrderDetails.OrderID, LocalPayment.AmountPaid, LocalPayment.CheckNumber, LocalPayment.BankName from LocalPayment, LocalOrderDetails where LocalOrderDetails.OrderID = LocalPayment.OrderID and LocalPayment.Store_ID = '" + Store + "' and LocalPayment.PaymentDate  between '" + paymentDate + "' and '" + paymentDate + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<LocalPayment> list = new List<LocalPayment>();
            while (sd.Read())
            {
                LocalPayment pay = new LocalPayment { OrderDetails = sd.GetGuid(0), payment = sd.GetDecimal(1), CheckNo = sd.GetInt32(2), Bankname = sd.GetString(3) };
                list.Add(pay);
            }
            return list;
        }

        
    }
}
