using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Lab2;
using ProductData;

namespace Lab2Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository productRepository;
        Product product;

        [TestInitialize]
        public void Initializate()
        {
            productRepository = new ProductRepository();
        }

        [TestCleanup]
        public void CleanUp()
        {
            productRepository = null;
        }

        [TestMethod]
        public void GetProductByNameTest()
        {
            //Arange
            product = new Product(5323, "car", "black car", DateTime.Now.AddDays(-32), 8000, 19);
            Product result;
            //Act
            result = productRepository.GetProductByName("car");
            //Assert
            Assert.IsTrue(product.Name == result.Name);
            Assert.IsTrue(product.Id == result.Id);
            Assert.IsTrue(product.Description == result.Description);
            Assert.IsTrue(product.Price == result.Price);
            Assert.IsTrue(product.VAT == result.VAT);
        }

        [TestMethod]
        public void FindAllProductsTest()
        {
            //Arange
            List<Product> result;
            //Act
            result = productRepository.FindAllProducts();
            //Assert
            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod]
        public void FindAllProductsTest2()
        {
            //Arange
            List<Product> result;
            productRepository.RemoveProductByName("car");
            productRepository.RemoveProductByName("bike");
            productRepository.RemoveProductByName("pen");
            //Act
            result = productRepository.FindAllProducts();
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void AddProductTest()
        {
            //Arange
            product = new Product(12345, "ball", "green ball", DateTime.Now.AddDays(-12), 50, 18);
            bool result;
            //Act
            result = productRepository.AddProduct(product);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddProductTest1()
        {
            //Arange
            bool result;
            //Act
            result = productRepository.AddProduct(null);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetProductByPositionTest()
        {
            //Arange
            Product result;
            //Act
            result = productRepository.GetProductByPosition(2);
            //Assert
            Assert.IsTrue(result.Name == "pen");
        }

        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod]
        public void GetProductByPositionTest1()
        {
            //Arange
            Product result;
            //Act
            result = productRepository.GetProductByPosition(-2);
            //Assert
        }

        [TestMethod]
        public void RemoveProductByNameTest()
        {
            //Arange
            bool result;
            //Act
            result = productRepository.RemoveProductByName("bike");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemoveProductByNameTest1()
        {
            //Arange
            bool result;
            //Act
            result = productRepository.RemoveProductByName("other");
            //Assert
            Assert.IsFalse(result);
        }
    }
}
