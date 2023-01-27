using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Employee : User
    {
        public Employee()
        {

        }
        public Employee(int Id, String name, int Job_Id, int Store, string street) : base (Id, name)
        {
            this.Job_Id = Job_Id;
            this.Store = Store;
            this.street = street;
        }

        public Employee(int employeeID, string name)
        {
            // TODO: Complete member initialization
            this.employeeID = employeeID;
            this.Name = name;
        }

        private int Job_Id;
        private int employeeID;
        public int JobID {
            get { return Job_Id; }
            set { Job_Id = value; }
        }

        private int Store;

        public int store
        {
            get { return Store; }
            set { Store = value; }
        }


        private string Street;

        public string street
        {
            get { return Street; }
            set { Street = value; }
        }
        
    }
}
