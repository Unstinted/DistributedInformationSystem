using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CosmeticsLibrary.FACADE;
using CosmeticsLibrary.BO;

/// <summary>
/// Summary description for NationalManagerService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class NationalManagerService : System.Web.Services.WebService {

    public NationalManagerService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    NationalManagerFacade nmf = new NationalManagerFacade();

    [WebMethod]
    public int Authenticates(string Username, string Password)
    {
        return nmf.Authenticates(Username, Password);
    }

    [WebMethod]
    public void SetNaDiscount(Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate)
    {
        nmf.SetNaDiscount(ProductInfo, EmployeeID, StartDate, EndDate, DiscountRate);
    }

    [WebMethod]
    public Customer GetCustomer(int customerId)
    {
        return nmf.GetCustomer(customerId);
    }

    [WebMethod]
    public void SetDiscount(Guid ProductInfo, int EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate, int StoreID)
    {
        nmf.SetDiscount(ProductInfo, EmployeeID, StartDate, EndDate, DiscountRate, StoreID);
    }

    [WebMethod]
    public OnlineOrderDetails[] GenerateProductReportDaily(DateTime orderDate)
    {
        return nmf.GenerateProductReportDaily(orderDate).ToArray();
    }

    [WebMethod]
    public OnlineOrderDetails[] GenerateProductReportWeekly(DateTime orderDate, DateTime OrderD)
    {
        return nmf.GenerateProductReportWeekly(orderDate, OrderD).ToArray();
    }

    [WebMethod]
    public Product GetProduct(Guid productid)
    {
        return nmf.GetProduct(productid);
    }

    [WebMethod]
    public OnlinePayment[] GenerateOnlinePayDaily(DateTime paymentDate)
    {
        return nmf.GenerateOnlinePayDaily(paymentDate).ToArray();
    }

    [WebMethod]
    public OnlinePayment[] GenerateOnlinePayWeekly(DateTime paymentDate, DateTime PayDay)
    {
        return nmf.GenerateOnlinePayWeekly(paymentDate, PayDay).ToArray();
    }

    [WebMethod]
    public Product[] ListOfProduct()
    {
        return nmf.GetListofProduct().ToArray();
    }

    [WebMethod]
    public Store[] GetListOfStore()
    {
        return nmf.GetStoreList().ToArray();
    }
}
