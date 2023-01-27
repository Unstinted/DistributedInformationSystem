using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.DAO
{
    public class InternetManagerDAO
    {
        SQLUtility sqlUtility = new SQLUtility();
        public int Authenticate(string Username, string Password)
        {
            int UserID = 0;
            String query = "select Employee_ID from Employee where Job_ID = 120 and Username = '" + Username + "' and Passwd = '" + Password + "'";
            SqlDataReader sd = new SQLUtility().ExecuteReader(query);
            if (sd.Read())
            {
                UserID = sd.GetInt32(0);
            }
            return UserID;
        }

        //Get Customer
        public Customer GetCustomer(int customerId)
        {
            string query = "Select CName from Customer where CustomerId = " + customerId;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    string name = sd.GetString(0);
                    Customer customer = new Customer(customerId, name);
                    return customer;
                }
            }

            return null;
        }



        //Set Local Discount
        public void SetDiscount(Product ProductInfo, Employee EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate)
        {
            String query = "insert into LocalDiscount(ProductCode, Employee_ID, DiscountStartDate, DiscountRate, DiscountEndDate) values ('" + ProductInfo + "', '" + EmployeeID + "', '" + StartDate + "', '" + EndDate + "', '" + DiscountRate + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        //Generate report of order daily
        public List<OnlineOrderDetails> GenerateProductReportDaily(DateTime orderDate)
        {
            string query = "SELECT OnlineOrders.OnlineOrderID, ProductCode, Quantity, Unitprice FROM OnlineOrders, OnlineOrderDetails	WHERE OnlineOrders.OnlineOrderID = OnlineOrderDetails.OnlineOrderID and OnlineOrders.OrderDate = '" + orderDate.ToString("yyyy-MM-dd") + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<OnlineOrderDetails> list = new List<OnlineOrderDetails>();
            while (sd.Read())
            {
                OnlineOrderDetails lod = new OnlineOrderDetails { OrderIdentity = sd.GetGuid(0), ProductDetail = sd.GetGuid(1), OrderQuantity = sd.GetInt32(2), Price = sd.GetDecimal(3) };
                list.Add(lod);
            }
            return list;
        }

        //Get Generate report of order weekly
        public List<OnlineOrderDetails> GenerateProductReportWeekly(DateTime orderDate, DateTime OrderD)
        {
            string query = "SELECT OnlineOrders.OnlineOrderID, ProductCode, Quantity, Unitprice FROM OnlineOrders, OnlineOrderDetails WHERE OnlineOrders.OnlineOrderID = OnlineOrderDetails.OnlineOrderID and OnlineOrders.OrderDate between '" + OrderD.ToString("yyyy-MM-dd") + "' and '" + OrderD.ToString("yyyy-MM-dd") + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<OnlineOrderDetails> list = new List<OnlineOrderDetails>();
            while (sd.Read())
            {
                OnlineOrderDetails lod = new OnlineOrderDetails { OrderIdentity = sd.GetGuid(0), ProductDetail = sd.GetGuid(1), OrderQuantity = sd.GetInt32(2), Price = sd.GetDecimal(3) };
                list.Add(lod);
            }
            return list;
        }



        //Generate Payment Report
        public List<OnlinePayment> GenerateOnlinePayDaily(DateTime paymentDate)
        {
            string query = "select OnlineOrderDetails.OnlineOrderID, OnlinePayment.Amount, OnlinePayment.CheckNumber, OnlinePayment.BankName from OnlinePayment, OnlineOrderDetails where OnlineOrderDetails.OnlineOrderID = OnlinePayment.OnlineOrderID and OnlinePayment.PaymentDate = '" + paymentDate + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<OnlinePayment> list = new List<OnlinePayment>();
            while (sd.Read())
            {
                OnlinePayment pay = new OnlinePayment { OrderDetails = sd.GetGuid(0), payment = sd.GetDecimal(1), CheckNo = sd.GetInt32(2), Bankname = sd.GetString(3) };
                list.Add(pay);
            }
            return list;
        }

        public List<OnlinePayment> GenerateOnlinePayWeekly(DateTime paymentDate, DateTime PayDay)
        {
            string query = "select OnlineOrderDetails.OnlineOrderID, OnlinePayment.Amount, OnlinePayment.CheckNumber, OnlinePayment.BankName from OnlinePayment, OnlineOrderDetails where OnlineOrderDetails.OnlineOrderID = OnlinePayment.OnlineOrderID and OnlinePayment.PaymentDate  between '" + paymentDate + "' and '" + paymentDate + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<OnlinePayment> list = new List<OnlinePayment>();
            while (sd.Read())
            {
                OnlinePayment pay = new OnlinePayment { OrderDetails = sd.GetGuid(0), payment = sd.GetDecimal(1), CheckNo = sd.GetInt32(2), Bankname = sd.GetString(3) };
                list.Add(pay);
            }
            return list;
        }

    }
}
