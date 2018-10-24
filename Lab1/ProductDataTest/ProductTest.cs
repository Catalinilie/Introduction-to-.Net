using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductData;
using FluentAssertions;

namespace ProductDataTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void VATTest()
        {
            Product product1 = new Product(5323, "car", "black car", DateTime.Now.AddDays(-32), 8000, 19);
            Product product2 = new Product(6434, "bike", "white bike", DateTime.Now.AddDays(-32), 500, 20);
            Product product3 = new Product(2334, "pen", "blue pen", DateTime.Now.AddDays(32), 1, 25);

            double result1 = product1.ComputeVAT();
            double result2 = product2.ComputeVAT();
            double result3 = product3.ComputeVAT();

            result1.Should().Be(1520);
            result1.Should().BeGreaterThan(1000);
            result2.Should().Be(100);
            result2.Should().BeLessThan(999);
            result3.Should().Be(0.25);
            result3.Should().BeGreaterThan(0);

            System.Console.WriteLine("Test pass with succes!");
        }
         [TestMethod]
        public void IsValidTest()
        {
            Product product1 = new Product(5323, "car", "black car", DateTime.Now.AddDays(-32), 8000, 19);
            Product product2 = new Product(6434, "bike", "white bike", DateTime.Now.AddDays(-32), 500, 20);

            Product product3 = new Product(2334, "pen", "blue pen", DateTime.Now.AddDays(32), 1, 25);
            Product product4 = new Product(1234, "headphones", "gray headphones", DateTime.Now.AddDays(50), 8000, 19);

            product1.IsValid().Should().BeTrue();
            product2.IsValid().Should().BeTrue();

            product3.IsValid().Should().BeFalse();
            product4.IsValid().Should().BeFalse();

            System.Console.WriteLine("Test pass with succes!");
        }
    }
}
