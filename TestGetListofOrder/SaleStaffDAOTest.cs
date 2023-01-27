using CosmeticsLibrary.DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CosmeticsLibrary.BO;

namespace TestGetListofOrder
{
    
    
    /// <summary>
    ///This is a test class for SaleStaffDAOTest and is intended
    ///to contain all SaleStaffDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SaleStaffDAOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Authenticate
        ///</summary>
        [TestMethod()]
        public void AuthenticateTest()
        {
            SaleStaffDAO target = new SaleStaffDAO(); // TODO: Initialize to an appropriate value
            string Username = "Mark"; // TODO: Initialize to an appropriate value
            string Password = "marklee"; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
           // actual = target.Authenticate(Username, Password);
           // Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetEmployee
        ///</summary>


        /// <summary>
        ///A test for CreatePayment
        ///</summary>

        /// <summary>
        ///A test for CreateLocalCustomer
        ///</summary>
        [TestMethod()]
        public void CreateLocalCustomerTest()
        {
            SaleStaffDAO target = new SaleStaffDAO(); // TODO: Initialize to an appropriate value
            string name = "Labanto Cole"; // TODO: Initialize to an appropriate value
            target.CreateLocalCustomer(name);
        }






        /// <summary>
        ///A test for CreateLocalOrder
        ///</summary>
        [TestMethod()]
        public void CreateLocalOrderTest1()
        {
            SaleStaffDAO target = new SaleStaffDAO(); // TODO: Initialize to an appropriate value // TODO: Initialize to an appropriate value
            DateTime OrderDate = DateTime.Now; // TODO: Initialize to an appropriate value
            int EmployeeID = 1; // TODO: Initialize to an appropriate value
            int CustomerID = 1; // TODO: Initialize to an appropriate value
            int StoreID = 10; // TODO: Initialize to an appropriate value
            target.CreateLocalOrder(OrderDate, EmployeeID, CustomerID, StoreID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetCustomer
        ///</summary>
        [TestMethod()]
        public void GetCustomerTest()
        {
            SaleStaffDAO target = new SaleStaffDAO(); // TODO: Initialize to an appropriate value
            int customerId = 1; // TODO: Initialize to an appropriate value
            string expectedName = "Dammy Benson"; // TODO: Initialize to an appropriate value
            Customer actual;
            actual = target.GetCustomer(customerId);
            Assert.AreEqual(expectedName, actual.Name);
        }

        /// <summary>
        ///A test for GetCustomer
        ///</summary>
        [TestMethod()]
        public void GetCustomerTest1()
        {
            SaleStaffDAO target = new SaleStaffDAO(); // TODO: Initialize to an appropriate value
            int customerId = 1; // TODO: Initialize to an appropriate value
            String expectedName = "Dammy Benson"; // TODO: Initialize to an appropriate value
            Customer actual;
            actual = target.GetCustomer(customerId);
            Assert.AreEqual(expectedName, actual.Name);
        }

        /// <summary>
        ///A test for CreateLocalCustomer
        ///</summary>
        [TestMethod()]
        public void CreateLocalCustomerTest1()
        {
            SaleStaffDAO target = new SaleStaffDAO(); // TODO: Initialize to an appropriate value
            string name = "Alapo"; // TODO: Initialize to an appropriate value
            target.CreateLocalCustomer(name);
        }

        /// <summary>
        ///A test for GetEmployeeStore
        ///</summary>
        [TestMethod()]
        public void GetEmployeeStoreTest()
        {
            SaleStaffDAO target = new SaleStaffDAO(); // TODO: Initialize to an appropriate value
            int employeeID = 1; // TODO: Initialize to an appropriate value
            String expectedName = "ada sincko street"; // TODO: Initialize to an appropriate value
            Store actual;
            //actual = target.GetEmployeeStore(employeeID);
           // Assert.AreEqual(expectedName, actual.StoreId);
        }
    }
}
