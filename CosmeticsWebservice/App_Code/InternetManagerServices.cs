using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CosmeticsLibrary.FACADE;
using CosmeticsLibrary.BO;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    InternetManagerFacade imf = new InternetManagerFacade();

    [WebMethod]
    public int Authenticate(string Username, string Password)
    {
        return imf.Authenticate(Username, Password);
    }


    [WebMethod]
    public void SetDiscount(Product ProductInfo, Employee EmployeeID, DateTime StartDate, DateTime EndDate, int DiscountRate)
    {
        imf.SetDiscount(ProductInfo, EmployeeID, StartDate, EndDate, DiscountRate);
    }



    [WebMethod]
    public OnlineOrderDetails[] GenerateProductReportDaily(DateTime orderDate)
    {
        return imf.GenerateProductReportDaily(orderDate);
    }

    [WebMethod]
    public OnlineOrderDetails[] GenerateProductReportWeekly(DateTime orderDate, DateTime OrderD)
    {
        return imf.GenerateProductReportWeekly(orderDate, OrderD);
    }

    [WebMethod]
    public OnlinePayment[] GenerateOnlinePayDaily(DateTime paymentDate)
    {
        return imf.GenerateOnlinePayDaily(paymentDate);
    }

    [WebMethod]
    public OnlinePayment[] GenerateOnlinePayWeekly(DateTime paymentDate, DateTime PayDay)
    {
        return imf.GenerateOnlinePayWeekly(paymentDate, PayDay);
    }
    
    
}
