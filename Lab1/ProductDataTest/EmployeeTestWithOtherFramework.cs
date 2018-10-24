using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductData;
using FluentAssertions;

namespace employeeDataTest
{
    [TestClass]
    public class EmployeeTestWithOtherFramework
    {

        [TestMethod]
        public void IsActive()
        {
            Employee employee1 = new Employee(5323, "Popescu", "Mihai", DateTime.Now.AddDays(-2332), 2000);
            Employee employee2 = new Employee(6434, "Ionescu", "Neculai", DateTime.Now.AddDays(-3122), 2500);
            Employee employee3 = new Employee(2334, "Anton", "Cosmin", DateTime.Now.AddDays(423), 1800);
            Employee employee4 = new Employee(2431, "Coman", "Eduard", DateTime.Now.AddDays(12), 3000);

            Assert.IsTrue(employee1.IsActive());
            Assert.IsTrue(employee2.IsActive());

            Assert.IsFalse(employee3.IsActive());
            Assert.IsFalse(employee3.IsActive());

            System.Console.WriteLine("Test pass with succes!");
        }
        [TestMethod]
        public void GetFullName()
        {
            Employee employee1 = new Employee(5323, "Popescu", "Mihai", DateTime.Now.AddDays(-2332), 2000);
            Employee employee2 = new Employee(6434, "Ionescu", "Neculai", DateTime.Now.AddDays(-3122), 2500);
            Employee employee3 = new Employee(2334, "Anton", "Cosmin", DateTime.Now.AddDays(423), 1800);
            Employee employee4 = new Employee(2431, "Coman", "Eduard", DateTime.Now.AddDays(12), 3000);

            Assert.AreEqual(employee1.GetFullName(), "Popescu Mihai");
            Assert.AreEqual(employee2.GetFullName(), "Ionescu Neculai");
            Assert.AreEqual(employee3.GetFullName(), "Anton Cosmin");
            Assert.AreEqual(employee4.GetFullName(), "Coman Eduard");

            System.Console.WriteLine("Test pass with succes!");
        }
    }
}
