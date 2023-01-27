using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CosmeticsLibrary.BO
{
    [Serializable]
    public class Job
    {
        public Job()
        {

        }
        public Job(int Job_ID, String Job_Title, int MaxSal, int MinSal, Employee EmployeeID)
        {
            this.Job_ID = Job_ID;
            this.Job_Title = Job_Title;
            this.MaxSal = MaxSal;
            this.MinSal = MinSal;
            this.EmployeeID = EmployeeID;
        }

        public Job(int jobID, string Job_Title)
        {
            // TODO: Complete member initialization
            this.JobID = jobID;
            this.Job_Title = Job_Title;
        }
        private int Job_ID;

        public int JobID
        {
            get { return Job_ID; }
            set { Job_ID = value; }
        }

        private String Job_Title;

        public String JobTitle
        {
            get { return Job_Title; }
            set { Job_Title = value; }
        }

        private int MaxSal;

        public int MaximumSalary
        {
            get { return MaxSal; }
            set { MaxSal = value; }
        }

        private int MinSal;

        public int MinimumSalary
        {
            get { return MinSal; }
            set { MinSal = value; }
        }

        private Employee EmployeeID;

        public Employee Employeeid
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        
        
    }
}
