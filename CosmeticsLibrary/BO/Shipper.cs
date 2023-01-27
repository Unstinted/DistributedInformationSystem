using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Shipper
    {
        public Shipper()
        {

        }
        public Shipper(int Shipper_ID, String CompName)
        {
            this.CompName = CompName;
            this.Shipper_ID = Shipper_ID;
        }

        private int Shipper_ID;

        public int ShipperID
        {
            get { return Shipper_ID; }
            set { Shipper_ID = value; }
        }

        private String CompName;

        public String CompanyName
        {
            get { return CompName; }
            set { CompName = value; }
        }

        public override string ToString()
        {

            return this.CompanyName;
        }
    }
}
