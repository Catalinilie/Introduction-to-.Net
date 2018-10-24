using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductData;
using FluentAssertions;

namespace employeeDataTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void IsActive()
        {
            Employee employee1 = new Employee(5323, "Popescu", "Mihai", DateTime.Now.AddDays(-2332), 2000);
            Employee employee2 = new Employee(6434, "Ionescu", "Neculai", DateTime.Now.AddDays(-3122), 2500);

            Employee employee3 = new Employee(2334, "Anton", "Cosmin", DateTime.Now.AddDays(423), 1800);
            Employee employee4 = new Employee(2431, "Coman", "Eduard", DateTime.Now.AddDays(12), 3000);

            employee1.IsActive().Should().BeTrue();
            employee2.IsActive().Should().BeTrue();

            employee3.IsActive().Should().BeFalse();
            employee4.IsActive().Should().BeFalse();

            System.Console.WriteLine("Test pass with succes!");
        }
        [TestMethod]
        public void GetFullName()
        {
            Employee employee1 = new Employee(5323, "Popescu", "Mihai", DateTime.Now.AddDays(-2332), 2000);
            Employee employee2 = new Employee(6434, "Ionescu", "Neculai", DateTime.Now.AddDays(-3122), 2500);
            Employee employee3 = new Employee(2334, "Anton", "Cosmin", DateTime.Now.AddDays(423), 1800);
            Employee employee4 = new Employee(2431, "Coman", "Eduard", DateTime.Now.AddDays(12), 3000);

            employee1.GetFullName().Should().Be("Popescu Mihai");
            employee2.GetFullName().Should().Be("Ionescu Neculai");
            employee3.GetFullName().Should().Be("Anton Cosmin");
            employee4.GetFullName().Should().Be("Coman Eduard");

            System.Console.WriteLine("Test pass with succes!");
        }
    }
}
