using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CosmeticsLibrary.BO;

namespace CosmeticsLibrary.DAO
{
    public class SaleStaffDAO
    {
        SQLUtility sqlUtility = new SQLUtility();
        public Employee Authenticate(string Username, string Password)
        {
           Employee emp  = null;
            String query = "select e.Employee_ID, e.Name, e.Store_ID, s.Street_Address from Employee e, store s " +
           " Where e.store_id = s.Store_ID and e.Username = '"+Username+"' and e.Passwd = '"+Password+"'and e.Job_ID = 100 ";
            
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            Console.WriteLine(query);
            if (sd.Read())
            {
                Console.WriteLine(sd.GetInt32(0));
                emp = new Employee();
                emp.ID = sd.GetInt32(0);
                emp.Name = sd.GetString(1);
                emp.store = sd.GetInt32(2);
                emp.street = sd.GetString(3);

            }
            return emp;
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

        //Get Customer List
        public List<Customer> GetCustomerList()
        {
            List<Customer> customers = new List<Customer>();
            string query = "select CustomerID, CustomerName from Customer";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
                while (sd.Read())
                {
                    Customer cust = GetCustomer(sd.GetInt32(0));
                    customers.Add(cust);
                }
            return customers;
        }



        // Get Product
        public Product GetProduct(Guid productid)
        {
            String query = "select ProductCode, ProductName, SaleUnitPrice, BuyUnitPrice, SupplierID from Product where ProductCode = '"+productid+"'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    String ProductName = sd.GetString(1);
                    decimal price = sd.GetDecimal(2);
                    Product pd = new Product(productid, ProductName, price);
                    return pd;
                }
            }
            return null;
        }


        //Get Employee
        public Employee GetEmployee(int employeeID)
        {
            Employee employee = null;
            String query = "select Name from Employee where Employee_ID = " + employeeID;
            Console.WriteLine(query + " " + employeeID);
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                     String name = sd.GetString(1);
                     employee = new Employee(employeeID, name);
                }
                
            }
      
            return employee;
            
        }

        public List<Employee> GetListofEmployee()
        {
            List<Employee> employee = new List<Employee>();
            String query = "select Employee_ID, Name from Employee";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
                while (sd.Read())
                {
                    Employee emp = GetEmployee(sd.GetInt32(0));
                    employee.Add(emp);
                }
                return employee;
        }

        //Get Store
        public Store GetStore(int storeID)
        {
            string query = "select Street_Address from store where Store_ID = " + storeID;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    string StoreAddress = sd.GetString(0);
                    Store store = new Store(storeID, StoreAddress);
                    return store;
                }
            }

            return null;
        }

        // Get List of Store
        public List<Store> GetStoreList()
        {
            List<Store> stores = new List<Store>();
            String query = "select Store_ID, Street_Address from store";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
                while (sd.Read())
                {
                    Store st = GetStore(sd.GetInt32(0));
                    stores.Add(st);
                }
            return stores;
        }

        public LocalOrder GetLocalOrder(int employeeID)
        {
            String query = "select * LocalOrder where l.Employee_ID = " + employeeID;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                if (sd.Read())
                {
                    Guid OrderID = sd.GetGuid(0);
                    DateTime OrderDate = sd.GetDateTime(1);
                    int Store_ID = sd.GetInt32(2);
                    Customer CustomerID = GetCustomer(sd.GetInt32(3));
                    int EmployeeID = sd.GetInt32(4);
                    LocalOrder lo = new LocalOrder(OrderID, OrderDate, Store_ID, CustomerID, EmployeeID);
                    return lo;
                }
            }
            return null;
        }


        //Create Customer
        public void CreateLocalCustomer(String name)
        {
            String query = "insert into Customer(CustomerName) values ('"+name+"')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        //Create Customer Order
        public void CreateLocalOrder(DateTime OrderDate, int EmployeeID, int CustomerID, int StoreID)
        {
            String query = "insert into LocalOrder(OrderDate, Employee_ID, CustomerID, Store_ID) values ('" + OrderDate + "', '"+ EmployeeID + "', '" + CustomerID + "', '"+StoreID+"')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        // Create OrderDetails
        public void LocalOrderDetails(Guid OrderID, Guid ProductCode, int Quantity, int UnitPrice)
        {
            String query = "insert into LocalOrderDetails(OrderID, ProductCode, Quantity, UnitPrice) values ('" + OrderID + "', '" + ProductCode + "', '" + Quantity + "', '" + getProductDiscountPrice(OrderID, ProductCode) + "') "+
            "Update Stock set Stock.QuantityInStock = Stock.QuantityInStock - LocalOrderDetails.Quantity " +
            " From LocalOrderDetails where Stock.ProductCode = LocalOrderDetails.ProductCode";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        private decimal getProductDiscountPrice(Guid OrderID, Guid ProductCode)
        {
            SQLUtility sqlUtility = new SQLUtility();
            String query = "SELECT Store_ID	FROM LocalOrder	WHERE OrderID = '" + OrderID +  "'";
            int storeId = (int)sqlUtility.ExecuteScalar(query);
            decimal price = 0;
            try
            {
                query = "SELECT SaleUnitPrice * (100 - DiscountRate)/100 FROM LocalDiscount, Product WHERE LocalDiscount.ProductCode = Product.ProductCode AND LocalDiscount.Store_Id = '" + storeId + "' AND LocalDiscount.ProductCode = '" + ProductCode + "'";
                price = (decimal)sqlUtility.ExecuteScalar(query);
            }
            catch (Exception)
            {
                price = GetProduct(ProductCode).UnitSalesPrice;
            }
            return price;
        }

        // View Product List
        public List<Product> GetListofProduct()
        {
            List<Product> product = new List<Product>();
            String query = "select * from Product";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            while (sd.Read())
            {
                Product prd = GetProduct(sd.GetGuid(0));
                product.Add(prd);
            }
            return product;
        }

        //List of LocalOrder
        public List<LocalOrder> GetListofOrder(int Employee_ID)
        {
            List<LocalOrder> localOrder = new List<LocalOrder>();
            String query = "select l.OrderID, l.OrderDate, l.CustomerID, l.Store_ID, s.street_address " +
            " from LocalOrder l, store s where l.store_ID = s.store_ID and l.Employee_ID = "+ Employee_ID ;
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            while (sd.Read())
            {
                Guid OrderID = sd.GetGuid(0);
                DateTime OrderDate = sd.GetDateTime(1);
                Customer CustomerID = GetCustomer(sd.GetInt32(2));
                int Store_ID = sd.GetInt32(3);
                string street = sd.GetString(4);
                LocalOrder lo = new LocalOrder(OrderID, OrderDate, CustomerID, Store_ID, street);
                localOrder.Add(lo);
            }
            return localOrder;
        }

        // FillinStock
        public void FillInStock(Guid ProductCode,DateTime StockDate, int EmployeeID, int QuantityInStock, int Store_ID)
        {
            String query = "insert into Stock(ProductCode, StockDate, Employee_ID, QuantityInStock, Store_ID) values ('" + ProductCode + "', '" + StockDate + "', '" + EmployeeID + "', '" + QuantityInStock + "', '"+Store_ID+"')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        //Get Stock Quantity of a product
        public List<Stock> GetStockAvailable(Guid productCode)
        {
            List<Stock> stock = new List<Stock>();
            String query = "select P.ProductCode, s.StockID, s.StockDate, s.Employee_ID, s.QuantityInStock, P.Store_ID "
           + " from Product p, Stock s where P.ProductCode = S.ProductCode and P.Store_ID = S.Store_ID and P.ProductCode =  '"+productCode+"'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
                while (sd.Read())
                {
                    int StockID = sd.GetInt32(1);
                    int EmployeeInfo = sd.GetInt32(3);
                    int QuantityInStock = Convert.ToInt32(sd.GetValue(4));
                    DateTime StockDate = sd.GetDateTime(2);
                    int StoreID = sd.GetInt32(5);
                    Guid Product = sd.GetGuid(0);
                    stock.Add(new Stock { StockId = StockID, EmployeeDetail = EmployeeInfo, StockQuantity = QuantityInStock, TheStockDate = StockDate, storeId = StoreID, product = Product });
                    
            }
            return stock;
        }

        //Create Payment for Order
        public void OfflinePayment(String OrderInfo, DateTime PaymentDate, double AmountPaid, int CheckNumber, String BankName, int StoreID)
        {
            String query = "insert into LocalPayment(OrderID, PaymentDate, AmountPaid, CheckNumber, BankName, Store_ID) values ('" + OrderInfo + "', '" + PaymentDate + "', '" + AmountPaid + "', '" + CheckNumber + "', '" + BankName + "','" + StoreID + "')";
            SQLUtility sqlUtility = new SQLUtility();
            sqlUtility.ExecuteNonQuery(query);
        }

        //Get order detail
        public List<LocalOrderDetails> GetOrderDetail(Guid localOrderId)
        {
            List<LocalOrderDetails> list = new List<LocalOrderDetails>();
            String query = "SELECT LocalOrder.OrderID, ProductCode, Quantity, Unitprice FROM LocalOrder, LocalOrderDetails WHERE LocalOrder.OrderID = LocalOrderDetails.OrderID AND LocalOrder.OrderID = '" + localOrderId + "'";
            SQLUtility sqlUtility = new SQLUtility();
            SqlDataReader sd = sqlUtility.ExecuteReader(query);
            {
                while (sd.Read())
                {
                    Guid orderId = sd.GetGuid(0);
                    Product product = GetProduct(sd.GetGuid(1));
                    int quantity = Convert.ToInt32(sd.GetValue(2));
                    decimal price = sd.GetDecimal(3);

                    list.Add(new LocalOrderDetails { OrderIdentity = orderId, ProductDetail = product, OrderQuantity = quantity, Price = price });
                }
            }
            return list;
        }



    }
}
