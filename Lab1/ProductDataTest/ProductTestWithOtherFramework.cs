using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductData;
using FluentAssertions;

namespace ProductDataTest
{
    [TestClass]
    public class ProductTestWithOtherFramework
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

            Assert.AreEqual(result1,1520);
            Assert.AreEqual(result2,100);
            Assert.AreEqual(result3,0.25);

            System.Console.WriteLine("Test pass with succes!");
        }
        [TestMethod]
        public void IsValidTest()
        {
            Product product1 = new Product(5323, "car", "black car", DateTime.Now.AddDays(-32), 8000, 19);
            Product product2 = new Product(6434, "bike", "white bike", DateTime.Now.AddDays(-32), 500, 20);

            Product product3 = new Product(2334, "pen", "blue pen", DateTime.Now.AddDays(32), 1, 25);
            Product product4 = new Product(1234, "headphones", "gray headphones", DateTime.Now.AddDays(50), 8000, 19);

            Assert.IsTrue(product1.IsValid());
            Assert.IsTrue(product2.IsValid());

            Assert.IsFalse(product3.IsValid());
            Assert.IsFalse(product4.IsValid());

            System.Console.WriteLine("Test pass with succes!");
        }
    }
}
