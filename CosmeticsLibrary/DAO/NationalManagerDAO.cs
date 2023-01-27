using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.DAO
{
    public class NationalManagerDAO : LocalManagerDAO
    {

        InternetManagerDAO internetDao = new InternetManagerDAO();


        public int Authenticates(string Username, string Password)
        {
            int UserID = 0;
            String query = "select Employee_ID from Employee where Job_ID = 130 and Username = '" + Username + "' and Passwd = '" + Password + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            if (sd.Read())
            {
                UserID = sd.GetInt32(0);
            }
            return UserID;
        }
        //Get Customer
        public Customer GetCustomer(int customerId)
        {
            return internetDao.GetCustomer(customerId);
        }


        //Set Local Discount
        public void SetNaDiscount(Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate)
        {
            String query = "insert into NationalDiscount(ProductCode, Employee_ID, DiscountStartDate, DiscountEndDate, DiscountRate) values ('"
                + ProductInfo + "', '" + EmployeeID + "', '" + StartDate + "', '" + EndDate + "', '" + DiscountRate + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        //Generate report of order daily
        public OnlineOrderDetails[] GenerateProductReportDaily(DateTime orderDate)
        {
            return internetDao.GenerateProductReportDaily(orderDate).ToArray();
        }

        //Get Generate report of order daily
        public OnlineOrderDetails[] GenerateProductReportWeekly(DateTime orderDate, DateTime OrderD)
        {
            return internetDao.GenerateProductReportWeekly(orderDate, OrderD).ToArray();
        }


        //Generate report for online payment
        public OnlinePayment[] GenerateOnlinePayDaily(DateTime paymentDate)
        {
            return internetDao.GenerateOnlinePayDaily(paymentDate).ToArray();

        }

        public OnlinePayment[] GenerateOnlinePayWeekly(DateTime paymentDate, DateTime PayDay)
        {
            return internetDao.GenerateOnlinePayWeekly(paymentDate, PayDay).ToArray();
        }



    }
}
