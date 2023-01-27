using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Store
    {
        public Store()
        {

        }


        public Store(int StoreID, string StoreAddress)
        {
            this.StoreID = StoreID;
            this.StoreAddress = StoreAddress;
        }

        private int StoreID;

        public int StoreId
        {
            get { return StoreID; }
            set { StoreID = value; }
        }

        private String StoreAddress;

        public String storeAddress
        {
            get { return StoreAddress; }
            set { StoreAddress = value; }
        }


        
    }
}
