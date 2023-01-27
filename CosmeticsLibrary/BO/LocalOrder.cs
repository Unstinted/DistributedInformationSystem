using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class LocalOrder
    {
        public LocalOrder()
        {

        }

        public LocalOrder(Guid OrderID, DateTime OrderDate, int Store_ID, Customer CustomerID, int EmployeeID)
        {
            this.EmployeeID = EmployeeID;
            
        }

        public LocalOrder(Guid OrderID, DateTime OrderDate, Customer CustomerID, int Store_ID, string street)
        {
            // TODO: Complete member initialization
            this.OrderID = OrderID;
            this.OrderDate = OrderDate;
            this.CustomerID = CustomerID;
            this.Store_ID = Store_ID;
            this.Street = street;
        }


        private String street;

        public String Street
        {
            get { return street; }
            set { street = value; }
        }

        private Guid OrderID;

        public Guid orderID
        {
            get { return OrderID; }
            set { OrderID = value; }
        }

        private DateTime OrderDate;

        public DateTime orderDate
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }
        

        private int EmployeeID;

        public int EmpD
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        private int Store_ID;

        public int storeID
        {
            get { return Store_ID; }
            set { Store_ID = value; }
        }

        private Customer CustomerID;

        public Customer cust
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }

        
        
    }
}
