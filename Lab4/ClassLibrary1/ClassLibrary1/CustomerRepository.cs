using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class CustomerRepository
    {
        ProductManagement _productManagement;
        public CustomerRepository(ProductManagement productManagement)
        {
            _productManagement = productManagement;
        }
        public void Create(Customer customer)
        {
            _productManagement.Customers.Add(customer);
            _productManagement.SaveChanges();
        }
        public void Update(Customer customer)
        {
            Customer updatedCustomer = _productManagement.Customers.Find(customer.Id);
            updatedCustomer.Name = "test";
            _productManagement.SaveChanges();
        }
        public void Delete(Customer customer)
        {
            _productManagement.Customers.Remove(customer);
            _productManagement.SaveChanges();
        }
        public Customer GetById(Guid id)
        {
            return _productManagement.Customers.Find(id);
        }
        public IEnumerable<Customer> GetAll()
        {
            return _productManagement.Customers;
        }
        public Customer GetCustomerByEmail(string email)
        {
            return _productManagement.Customers.Where(customer => customer.Email == email).First();
        }
    }
}