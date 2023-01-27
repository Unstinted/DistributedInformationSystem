using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Supplier
    {
        public Supplier()
        {

        }
        public Supplier(int SupplierID, String CompName, String ConName, String ConTitle, String Email, int PhoneNo, String SuppAdd, String City, String Country, String Website)
        {
            this.PhoneNo = PhoneNo;
            this.SuppAdd = SuppAdd;
            this.SupplierID = SupplierID;
            this.Website = Website;
            this.City = City;
            this.CompName = CompName;
            this.ConName = ConName;
            this.ConTitle = ConTitle;
            this.Email = Email;
            this.Country = Country;
        }

        private int SupplierID;

        public int Supplierid
        {
            get { return SupplierID; }
            set { SupplierID = value; }
        }

        private String CompName;

        public String CompanyName
        {
            get { return CompName; }
            set { CompName = value; }
        }

        private String ConName;

        public String ContactName
        {
            get { return ConName; }
            set { ConName = value; }
        }

        private String ConTitle;

        public String ContactJobTitle
        {
            get { return ConTitle; }
            set { ConTitle = value; }
        }

        private int PhoneNo;

        public int PhoneNumber
        {
            get { return PhoneNo; }
            set { PhoneNo = value; }
        }

        private string Email;

        public string EmailAddress
        {
            get { return Email; }
            set { Email = value; }
        }

        private String SuppAdd;

        public String SupplierAddress
        {
            get { return SuppAdd; }
            set { SuppAdd = value; }
        }

        private String City;

        public String city
        {
            get { return City; }
            set { City = value; }
        }

        private String Country;

        public String CountryName
        {
            get { return Country; }
            set { Country = value; }
        }

        private String Website;

        public String WebsiteAddress
        {
            get { return Website; }
            set { Website = value; }
        }
        
        
    }
}
