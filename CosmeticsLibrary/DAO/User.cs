using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class User
    {
        public User()
        {

        }
        public User(int Id, String name)
        {
            this.Id = Id;
            this.name = name;
        }

        private int Id;
        public int ID
        {
            get {return Id;}
            set {Id = value;}
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    
    }
}
