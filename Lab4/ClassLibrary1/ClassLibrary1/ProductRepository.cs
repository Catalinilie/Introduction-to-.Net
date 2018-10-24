using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class ProductRepository
    {
        ProductManagement _productManagement;

        public ProductRepository(ProductManagement productManagement)
        {
            _productManagement = productManagement;
        }

        public void Create(Product product)
        {
            _productManagement.Products.Add(product);
            _productManagement.SaveChanges();
        }

        public void Update(Product product)
        {
            Product updatedProduct = _productManagement.Products.Find(product.Id);
            updatedProduct.Name = product.Name;
            updatedProduct.Description = product.Description;
            updatedProduct.StartDate = product.StartDate;
            updatedProduct.Price = product.Price;
            updatedProduct.VAT = product.VAT;
            _productManagement.SaveChanges();
        }

        public void Delete(Product product)
        {
            _productManagement.Products.Remove(product);
            _productManagement.SaveChanges();
        }

        public Product GetById(Guid id)
        {
            return _productManagement.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productManagement.Products;
        }

        public IEnumerable<Product> GetProductsByPrice(double price)
        {
            return _productManagement.Products.Where(product => product.Price == price);
        }
    }
}