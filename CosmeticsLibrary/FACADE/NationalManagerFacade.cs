using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CosmeticsLibrary.DAO;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.FACADE
{
    public class NationalManagerFacade : MarshalByRefObject
    {
        NationalManagerDAO nmd = new NationalManagerDAO();

        public int Authenticates(string Username, string Password)
        {
            return nmd.Authenticates(Username, Password);
        }

        public void SetNaDiscount(Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate)
        {
            nmd.SetNaDiscount(ProductInfo, EmployeeID, StartDate, EndDate, DiscountRate);
        }

        public Customer GetCustomer(int customerId)
        {
            return nmd.GetCustomer(customerId);
        }

        public void SetDiscount(Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate, int StoreID)
        {
            nmd.SetDiscount(ProductInfo, EmployeeID, StartDate, EndDate, DiscountRate, StoreID);
        }

        public OnlineOrderDetails[] GenerateProductReportDaily(DateTime orderDate)
        {
            return nmd.GenerateProductReportDaily(orderDate).ToArray();
        }

        public OnlineOrderDetails[] GenerateProductReportWeekly(DateTime orderDate,  DateTime OrderD)
        {
            return nmd.GenerateProductReportWeekly(orderDate, OrderD).ToArray();
        }


        public Product GetProduct(Guid productid)
        {
            return nmd.GetProduct(productid);
        }

        public OnlinePayment[] GenerateOnlinePayDaily(DateTime paymentDate)
        {
            return nmd.GenerateOnlinePayDaily(paymentDate).ToArray();
        }

        public OnlinePayment[] GenerateOnlinePayWeekly(DateTime paymentDate, DateTime PayDay)
        {
            return nmd.GenerateOnlinePayWeekly(paymentDate, PayDay).ToArray();
        }

        public Product[] GetListofProduct()
        {
            return nmd.GetListofProduct().ToArray();
        }

        public Store[] GetStoreList()
        {
            return nmd.GetStoreList().ToArray();
        }
    }
}
