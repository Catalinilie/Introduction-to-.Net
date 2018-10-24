using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;

namespace Lab2Test
{
    [TestClass]
    public class ManagerTest
    {
        public DateTime StartDate1;
        public DateTime EndDate1;
        public Manager manager;

        [TestInitialize]
        public void Initialize()
        {
            StartDate1 = DateTime.Now.AddYears(-1);
            EndDate1 = DateTime.Now.AddYears(1);
            manager = new Manager(1, "Catalin", "Prisacariu", StartDate1, EndDate1, 1000);
        }

        [TestCleanup]
        public void CleanUp()
        {
            manager = null;
        }

        [TestMethod]
        public void GetFullNameTest()
        {
            //Arange
           
            //Act
            String result = manager.GetFullName();
            //Assert
            Assert.IsTrue(result == "Prisacariu Catalin");
        }

        [TestMethod]
        public void IsActiveTest()
        {
            //Arange
            
            //Act
            bool result = manager.IsActive(DateTime.Now);
            //Assert
            Assert.IsTrue(result == true);
        }

        [TestMethod]
        public void IsActiveTest1()
        {
            //Arange

            //Act
            bool result = manager.IsActive(DateTime.Now.AddYears(2));
            //Assert
            Assert.IsTrue(result == false);
        }

        [TestMethod]
        public void SalutationTest()
        {
            //Arange

            //Act
            String result = manager.Salutation();
            //Assert
            Assert.IsTrue(result == "Hello manager");
        }
    }
}
