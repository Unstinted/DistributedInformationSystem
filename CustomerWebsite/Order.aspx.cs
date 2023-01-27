using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    CustomerSrv.CustomerServiceSoapClient customerFacade = new CustomerSrv.CustomerServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadAllProduct();
            loadShipper();
            loadCustomer();
        }
    }

    private void loadCustomer()
    {
        CustTxt.Text = Session["Customer"].ToString();
    }

    private void loadShipper()
    {
        DropDownList3.DataSource = customerFacade.GetshipperList();
        DropDownList3.DataBind();
    }
    private void loadAllProduct()
    {
        
        //DropDownList1.DataSource = customerFacade.GetListofProducts();
        //DropDownList1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int CustomerID = Int32.Parse(Session["Customer"].ToString());
        DateTime OrderDate = Ordate.SelectedDate;
        DateTime requiredDate = ReqDate.SelectedDate;
        String ShipName = TextBox1.Text;
        int ShipperID = Convert.ToInt32(DropDownList3.SelectedValue);
        int ShipPostcode = Int32.Parse(TextBox6.Text);
        String ShipperAdd = TextBox3.Text;
        String ShipCity = TextBox4.Text;
        String ShipProv = TextBox5.Text;
        String ShipCountry = DropDownList2.SelectedValue;
        customerFacade.CreateOrder(CustomerID, OrderDate, requiredDate, ShipName, ShipperID, ShipPostcode, ShipperAdd, ShipCity, ShipProv, ShipCountry);
        Response.Redirect("OrderConfirnation.aspx");
    }
}