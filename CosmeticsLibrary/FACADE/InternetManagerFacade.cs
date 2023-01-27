using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CosmeticsLibrary.DAO;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.FACADE
{
    public class InternetManagerFacade : MarshalByRefObject
    {
        InternetManagerDAO imd = new InternetManagerDAO();

        public int Authenticate(string Username, string Password)
        {
            return imd.Authenticate(Username, Password);
        }



        public void SetDiscount(Product ProductInfo, Employee EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate)
        {
            imd.SetDiscount(ProductInfo, EmployeeID, StartDate, EndDate, DiscountRate);
        }


        public OnlineOrderDetails[] GenerateProductReportDaily(DateTime orderDate)
        {
            return imd.GenerateProductReportDaily(orderDate).ToArray();
        }

        public OnlineOrderDetails[] GenerateProductReportWeekly(DateTime orderDate, DateTime OrderD)
        {
            return imd.GenerateProductReportWeekly(orderDate, OrderD).ToArray();
        }

        public OnlinePayment[] GenerateOnlinePayDaily(DateTime paymentDate)
        {
            return imd.GenerateOnlinePayDaily(paymentDate).ToArray();
        }

        public OnlinePayment[] GenerateOnlinePayWeekly(DateTime paymentDate, DateTime PayDay)
        {
            return imd.GenerateOnlinePayWeekly(paymentDate, PayDay).ToArray();
        }

    }
}
