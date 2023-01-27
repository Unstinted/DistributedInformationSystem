using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDetail : System.Web.UI.Page
{
    CustomerSrv.CustomerServiceSoapClient customerFacade = new CustomerSrv.CustomerServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadOrderDetail();
        }


    }

    private void loadOrderDetail()
    {
        //int customerId = (int)Session["Customer"];

        //GridView1.DataSource = customerFacade.GetListofOnlineOrder(customerId);
        //GridView1.DataBind();
    }
}