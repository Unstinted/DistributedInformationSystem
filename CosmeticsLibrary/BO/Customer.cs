using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Customer : User
    {
        public Customer()
        {

        }

        public Customer(int Id, String name): base (Id, name)
        {


        }


        public override string ToString()
        {
            return this.Name;
        }

        
    }
}
