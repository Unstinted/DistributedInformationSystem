using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CosmeticsLibrary.FACADE;
using CosmeticsLibrary.BO;

/// <summary>
/// Summary description for CustomerService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CustomerService : System.Web.Services.WebService {

    public CustomerService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    CustomerFacade cf = new CustomerFacade();
    [WebMethod]
    public int Authenticate(String username, String password)
    {
        return cf.Authenticate(username, password);
    }

    [WebMethod]
    public Product[] GetListofProducts()
    {
        return cf.GetListofProducts();
    }

    [WebMethod]
    public OnlineOrder[] GetListofOnlineOrder(int CustomerId)
    {
        return cf.GetListofOnlineOrder(CustomerId);
    }

    [WebMethod]
    public Shipper[] GetshipperList()
    {
        return cf.GetshipperList().ToArray();
    }

    [WebMethod]
    public Product GetProduct(Guid productCode)
    {
        return cf.GetProduct(productCode);
    }

    [WebMethod]
    public LocalDiscount getProductLaDiscount(Guid productCode)
    {
        return cf.getProductLaDiscount(productCode);
    }

    [WebMethod]
    public NationalDiscount getProductNaDiscount(Guid productCode)
    {
        return cf.getProductNaDiscount(productCode);
    }

    [WebMethod]
    public OnlineOrderDetails[] GetListofOnlineOrderDetails(Guid orderID)
    {
        return cf.GetListofOnlineOrderDetails(orderID);
    }

    [WebMethod]
    public void CreatePayment(OnlineOrder OrderId, DateTime PayDate, int AmtPaid, int CheckNum, String BankInfo, int UnitPrice, int UnitSold, int TotalPurchasedPrice, Product productID)
    {
        cf.CreatePayment(OrderId, PayDate, AmtPaid, CheckNum, BankInfo, UnitPrice, UnitSold, TotalPurchasedPrice, productID);
    }

    [WebMethod]
    public void CreateOnlineOrderDetails(OnlineOrder OnlineOrderID, Guid productCode, int quantity, int Unitprice)
    {
        cf.CreateOnlineOrderDetails(OnlineOrderID, productCode, quantity, Unitprice);
    }

    [WebMethod]
    public void CreateOrder(int Customer, DateTime RequiredDate, DateTime onlineOrderDate, String shipToName,
            int ShipperID, int postCode, String shipToCountry, String ShipToProv, string shipToAdd, string shipToCity)
    {
        cf.CreateOrder(Customer, RequiredDate, onlineOrderDate, shipToName, ShipperID, postCode, shipToCountry, ShipToProv, shipToAdd, shipToCity);
    }

    [WebMethod]
    public void CreateCustomer(String name)
    {
        cf.CreateCustomer(name);
    }
    
}
