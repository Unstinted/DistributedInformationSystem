using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CosmeticsLibrary.DAO;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.FACADE
{
    public class SalesStaffFacade : MarshalByRefObject
    {
        SaleStaffDAO ssd = new SaleStaffDAO();

        public Employee Authenticate(string Username, string Password)
        {
            return ssd.Authenticate(Username, Password);
        }


        public void CreateLocalCustomer(String name)
        {
            ssd.CreateLocalCustomer(name);
        }

        public void CreateLocalOrder(DateTime OrderDate, int EmployeeID, int CustomerID, int StoreID)
        {
            ssd.CreateLocalOrder(OrderDate, EmployeeID, CustomerID, StoreID);
        }

        public void LocalOrderDetails(Guid OrderID, Guid ProductCode, int Quantity, int UnitPrice)
        {
            ssd.LocalOrderDetails(OrderID, ProductCode, Quantity, UnitPrice);
        }

        public Product[] GetListofProduct()
        {
            return ssd.GetListofProduct().ToArray();
        }

        public LocalOrder[] GetListofOrder(int Employee_ID)
        {
            return ssd.GetListofOrder(Employee_ID).ToArray();
        }

        public void FillInStock(Guid ProductCode, DateTime StockDate, int EmployeeID, int QuantityInStock, int Store_ID)
        {
            ssd.FillInStock(ProductCode, StockDate, EmployeeID, QuantityInStock, Store_ID);
        }


        public void OfflinePayment(String OrderInfo, DateTime PaymentDate, double AmountPaid, int CheckNumber, String BankName, int StoreID)
        {
            ssd.OfflinePayment(OrderInfo, PaymentDate, AmountPaid, CheckNumber, BankName, StoreID);
        }

        public Store[] GetStoreList()
        {
            return ssd.GetStoreList().ToArray();
 
        }

        public Employee[] GetListofEmployee() 
        {
            return ssd.GetListofEmployee().ToArray();
 
        }

        public Customer[] GetCustomerList()
        {
            return ssd.GetCustomerList().ToArray();
        }

        public Employee GetEmployee(int employeeID)
        {
            return ssd.GetEmployee(employeeID);
        }



        public LocalOrderDetails[] GetOrderDetail(Guid localOrderId)
        {
            return ssd.GetOrderDetail(localOrderId).ToArray();
        }

        public Stock[] GetStockAvailable(Guid productCode)
        {
            return ssd.GetStockAvailable(productCode).ToArray();
        }

    }
}
