using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Login : System.Web.UI.Page
{

    CustomerSrv.CustomerServiceSoapClient customerFacade = new CustomerSrv.CustomerServiceSoapClient();


    protected void Page_Load(object sender, EventArgs e)
    {
        
    }



    protected void LoginUser_LoggingIn(object sender, LoginCancelEventArgs e)
    {
        int customerId = customerFacade.Authenticate(LoginUser.UserName, LoginUser.Password);

        if (customerId != 0)
        {
            //correct input
            Session["Customer"] = customerId;
            //Session["CustomerName"] = getCustomerById(customerId);
            Response.Redirect("~/Order.aspx", true);
        }
        else
        {
            //incorrect input
            e.Cancel = true;
        }

    }
}
