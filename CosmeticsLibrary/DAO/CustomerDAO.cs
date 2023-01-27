using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CosmeticsLibrary.BO;
using System.Data;

namespace CosmeticsLibrary.DAO
{
    public class CustomerDAO
    {

        //Authenticate and return the id of the customer.
        public int Authenticate(string Username, string Password)
        {
            int ret = 0;
            string query = "Select CustomerId from Customer where Username='" + Username + "' and Passwd='" + Password + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            if (sd.Read())
            {
                ret = sd.GetInt32(0);
            }
            return ret;
        }

        //Get Customer
        public Customer GetCustomer(int customerId)
        {
            string query = "select CustomerName from Customer where CustomerID =  " + customerId;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    string name = sd.GetString(0);
                    Customer customer = new Customer(customerId, name);
                    return customer;
                }
            }

            return null;
        }

        //Get Product list
        public List<Product> GetListofProduct()
        {
            List<Product> product = new List<Product>();
            String query = "select ProductCode, ProductName, SaleUnitPrice from Product";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            while (sd.Read())
            {
                Guid ProductCode = sd.GetGuid(0);
                String ProductName = sd.GetString(1);
                int SaleUnitPrice = Convert.ToInt32(sd.GetDecimal(2));
                Product prd = new Product(ProductCode, ProductName, SaleUnitPrice);
                product.Add(prd);
            }
            return product;
        }
        //Create Order
        public void CreateOrder(int Customer, DateTime RequiredDate, DateTime onlineOrderDate, String shipToName,
            int ShipperID, int postCode, String shipToCountry, String ShipToProv, string shipToAdd, string shipToCity)
        {
            string query = "insert into OnlineOrders( CustomerID, OrderDate, RequireDate, ShipToName, ShipperID, ShipToAddress,  ShipToCity, ShipToProvince, ShipToCountry, ShipToPostCode) values ('" + Customer + "', '" + RequiredDate + "', '" + onlineOrderDate + "', '" + shipToName + "', '" + ShipperID + "', '" + shipToAdd + "','" + shipToCity + "', '" + ShipToProv + "', '" + shipToCountry + "', '" + postCode + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query); 
        }
        //Create OrderDetails
        public void CreateOnlineOrderDetails(OnlineOrder OnlineOrderID, Guid productCode, int quantity, int Unitprice)
        {
            String query = "insert into OnlineOrderDetails(OnlineOrderID, ProductCode, Quantity, Unitprice) values ('" + OnlineOrderID + "', '" + productCode + "', '" + quantity + "', '" + Unitprice + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }


        //Get List of OrderDetails
        public List<OnlineOrderDetails> GetListofOnlineOrderDetail(Guid orderID)
        {
            List<OnlineOrderDetails> onlineOrderDetail = new List<OnlineOrderDetails>();
            String query = "select ProductCode,Quantity, Unitprice from OnlineOrderDetails where OnlineOrderID =" + orderID;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
                while(sd.Read()){
                    OnlineOrderDetails od = new OnlineOrderDetails { ProductDetail = sd.GetGuid(0), OrderQuantity = sd.GetInt32(1), Price = sd.GetInt32(2) };
                    onlineOrderDetail.Add(od);
                }
            return onlineOrderDetail;
        }


        //Get Shippers Values
        public List<Shipper> GetshipperList()
        {
            List<Shipper> shipper = new List<Shipper>();
            string query = "select * from Shipper";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
                while (sd.Read())
                {
                    Shipper sp = new Shipper { ShipperID = sd.GetInt32(3), CompanyName = sd.GetString(0) };
                    shipper.Add(sp);
                }
            return shipper;

        }

        //Get List of Orders Made
        public List<OnlineOrder> GetListofOnlineOrder(int CustomerId)
        {
            String query = "select OnlineOrderId, OrderDate, RequireDate, ShipperID, ShipToAddress, ShipToCity, ShipToName from OnlineOrders where CustomerID = " + CustomerId;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            List<OnlineOrder> onlineOrder = new List<OnlineOrder>();
                while (sd.Read())
                {

                    OnlineOrder On = new OnlineOrder { order = sd.GetGuid(0), OrderDate = sd.GetDateTime(1), ReqDate = sd.GetDateTime(2), theShipper = sd.GetInt32(3), ShipAdd = sd.GetString(4), ShipCity = sd.GetString(5), shipName = sd.GetString(6)};
                    onlineOrder.Add(On);
                }
            return onlineOrder;

        }

        //Get Product
        public Product GetProduct(Guid productCode)
        {
            string query = "select productName from Product where ProductCode = " +productCode;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    string ProductName = sd.GetString(0);
                    Product product = new Product(ProductName);
                    return product;
                }
            }

            return null;
        }

        //Get LocalDiscount on Product
        public LocalDiscount getProductLaDiscount(Guid productCode)
        {
            string query = "select DiscountRate from LocalDiscount where ProductCode = " + productCode;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    int DiscountRate = sd.GetInt32(0);
                    LocalDiscount discount = new LocalDiscount(DiscountRate);
                    return discount;
                }
            }
            return null;
        }


        //Get NationalDiscount on Product
        public NationalDiscount getProductNaDiscount(Guid productCode)
        {
            string query = "select DiscountRate from LocalDiscount where ProductCode = " + productCode;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    int DiscountRate = sd.GetInt32(0);
                    NationalDiscount discount = new NationalDiscount(DiscountRate);
                    return discount;
                }
            }
            return null;
        }

        //Create Payment for Order
        public void CreatePayment(OnlineOrder OrderId, DateTime PayDate, int AmtPaid, int CheckNum, String BankInfo, int UnitPrice, int UnitSold, int TotalPurchasedPrice, Product productID)
        {
            String query = "insert into OnlinePayment(OnlineOrderID, PaymentDate, Amount, CheckNumber, BankName, UnitPrice, UnitSold, TotalPurchasedPrice, ProductCode) values ('" + OrderId + "', '" + PayDate + "', '" + AmtPaid + "', '" + CheckNum + "', '" + BankInfo + "','" + UnitPrice + "', '" + UnitSold + "', '" + TotalPurchasedPrice + "', '" + productID + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        public void CreateCustomer(String name)
        {
            String query = "insert into Customer(CustomerName) values ('" + name + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

    }
}
