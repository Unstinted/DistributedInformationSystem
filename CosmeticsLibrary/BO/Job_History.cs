using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Job_History
    {
        public Job_History()
        {

        }
        public Job_History(Employee EmployeeID, DateTime StartDate, DateTime EndDate, Job Job_ID, Store StoreID)
        {
            this.StoreID = StoreID;
            this.EmployeeID = EmployeeID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.StoreID = StoreID;
        }

        private Employee EmployeeID;

        public Employee Employeeid
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        private DateTime StartDate;

        public DateTime Startdate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }

        private DateTime EndDate;

        public DateTime Enddate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }

        private Job Job_ID;

        public Job JobID
        {
            get { return Job_ID; }
            set { Job_ID = value; }
        }

        private Store StoreID;

        public Store StoreDetail
        {
            get { return StoreID; }
            set { StoreID = value; }
        }
        
    }
}
