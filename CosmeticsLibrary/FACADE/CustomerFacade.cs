using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CosmeticsLibrary.DAO;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.FACADE
{
    public class CustomerFacade : MarshalByRefObject
    {
        CustomerDAO cdo = new CustomerDAO();
        public int Authenticate(string Username, String Password)
        {
            return cdo.Authenticate(Username, Password);
        }

        public Product[] GetListofProducts()
        {
            return cdo.GetListofProduct().ToArray();
        }

        public OnlineOrder[] GetListofOnlineOrder(int CustomerId)
        {
            return cdo.GetListofOnlineOrder(CustomerId).ToArray();
        }

        public Shipper[] GetshipperList() 
        {
            return cdo.GetshipperList().ToArray();
        }

        public Product GetProduct(Guid productCode)
        {
            return cdo.GetProduct(productCode);
        }

        public LocalDiscount getProductLaDiscount(Guid productCode)
        {
            return cdo.getProductLaDiscount(productCode);
        }

        public NationalDiscount getProductNaDiscount(Guid productCode)
        {
            return cdo.getProductNaDiscount(productCode);
        }


        public OnlineOrderDetails[] GetListofOnlineOrderDetails(Guid orderID)
        {
            return cdo.GetListofOnlineOrderDetail(orderID).ToArray();
        }

        public void CreatePayment(OnlineOrder OrderId, DateTime PayDate, int AmtPaid, int CheckNum, String BankInfo, int UnitPrice, int UnitSold, int TotalPurchasedPrice, Product productID)
        {
            cdo.CreatePayment(OrderId, PayDate, AmtPaid, CheckNum, BankInfo, UnitPrice, UnitSold, TotalPurchasedPrice, productID);
        }

        public void CreateOnlineOrderDetails(OnlineOrder OnlineOrderID, Guid productCode, int quantity, int Unitprice)
        {
            cdo.CreateOnlineOrderDetails(OnlineOrderID, productCode, quantity, Unitprice);
        }

        public void CreateOrder(int Customer, DateTime RequiredDate, DateTime onlineOrderDate, String shipToName,
            int ShipperID, int postCode, String shipToCountry, String ShipToProv, string shipToAdd, string shipToCity)
        {
            cdo.CreateOrder(Customer, RequiredDate, onlineOrderDate, shipToName, ShipperID, postCode, shipToCountry, ShipToProv, shipToAdd, shipToCity);
        }

        public void CreateCustomer(String name)
        {
            cdo.CreateCustomer(name);
        }


    }
}
