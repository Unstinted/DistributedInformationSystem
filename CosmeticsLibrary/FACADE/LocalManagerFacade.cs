using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CosmeticsLibrary.DAO;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.FACADE
{
    public class LocalManagerFacade : SalesStaffFacade
    {
        LocalManagerDAO lmd = new LocalManagerDAO();

        public Employee Authenticating(string Username, string Password)
        {
            return lmd.Authenticating(Username, Password);
        }

        public void SetDiscount(Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate, int StoreID)
        {
            lmd.SetDiscount(ProductInfo, EmployeeID, StartDate, EndDate, DiscountRate, StoreID);
        }

        public LocalOrderDetails[] GenerateProductReportDaily(DateTime orderDate, int storeId)
        {
            return lmd.GenerateProductReportDaily(orderDate, storeId).ToArray();
        }

        public LocalOrderDetails[] GenerateProductReportWeekly(DateTime orderDate, DateTime OrderD, int storeId)
        {
            return lmd.GenerateProductReportWeekly(orderDate, OrderD, storeId).ToArray();
        }

        public Stock[] GenerateStockReportDaily(int StoreId, DateTime stockDate)
        {
            return lmd.GenerateStockReportDaily(StoreId, stockDate).ToArray();
        }

        public Stock[] GenerateStockReportWeekly(int StoreId, DateTime stockDate, DateTime Stockdate)
        {
            return lmd.GenerateStockReportWeekly(StoreId, stockDate, Stockdate).ToArray();
        }


        public LocalPayment[] GenerateLocalPayDaily(DateTime paymentDate, int Store)
        {
            return lmd.GenerateLocalPayDaily(paymentDate, Store).ToArray();
        }

        public LocalPayment[] GenerateLocalPayWeekly(DateTime paymentDate, DateTime PayDay, int Store)
        {
            return lmd.GenerateLocalPayWeekly(paymentDate, PayDay, Store).ToArray();
        }

    }
}
