using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class OnlineOrder
    {
        public OnlineOrder()
        {

        }
        public OnlineOrder(Guid IntOrderID, int theCustomer, DateTime RequiredDate, DateTime OnlineOrderDate, String ShipToName,
            int ShipperName, int PostCode, String ShipToCountry, String ShipToProv, string ShipToAdd, string ShipToCity)
        {
            this.RequiredDate = RequiredDate;
            this.IntOrderID = IntOrderID;
            this.OnlineOrderDate = OnlineOrderDate;
            this.theCustomer = theCustomer;
            this.ShipToName = ShipToName;
            this.ShipToAdd = ShipToAdd;
            this.ShipToCity = ShipToCity;
            this.ShipToProv = ShipToProv;
            this.ShipToCountry = ShipToCountry;
            this.PostCode = PostCode;
            this.ShipperName = ShipperName;
        }


        private Guid IntOrderID;

        public Guid order
        {
            get { return IntOrderID; }
            set { IntOrderID = value; }
        }


        private DateTime RequiredDate;

        public DateTime ReqDate
        {
            get { return RequiredDate; }
            set { RequiredDate = value; }
        }

        private DateTime OnlineOrderDate;

        public DateTime OrderDate
        {
            get { return OnlineOrderDate; }
            set { OnlineOrderDate = value; }
        }

        private int theCustomer;

        public int cust
        {
            get { return theCustomer; }
            set { theCustomer = value; }
        }

        private string ShipToName;

        public string shipName
        {
            get { return ShipToName; }
            set { ShipToName = value; }
        }

        private String ShipToAdd;

        public String ShipAdd
        {
            get { return ShipToAdd; }
            set { ShipToAdd = value; }
        }

        private String ShipToCity;

        public String ShipCity
        {
            get { return ShipToCity; }
            set { ShipToCity = value; }
        }

        private int PostCode;

        public int postCd
        {
            get { return PostCode; }
            set { PostCode = value; }
        }

        private string ShipToProv;

        public string ShipProv
        {
            get { return ShipToProv; }
            set { ShipToProv = value; }
        }

        private string ShipToCountry;

        public string ShipCountry
        {
            get { return ShipToCountry; }
            set { ShipToCountry = value; }
        }

        private int ShipperName;

        public int theShipper
        {
            get { return ShipperName; }
            set { ShipperName = value; }
        }
        
        
    }
}
