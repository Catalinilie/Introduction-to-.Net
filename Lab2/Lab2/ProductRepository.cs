using System;
using System.Collections.Generic;
using System.Text;
using ProductData;

namespace Lab2
{
    public class ProductRepository
    {
        private List<Product> products = new List<Product>();

        public ProductRepository()
        {
            Product product1 = new Product(5323, "car", "black car", DateTime.Now.AddDays(-32), 8000, 19);
            Product product2 = new Product(6434, "bike", "white bike", DateTime.Now.AddDays(-32), 500, 20);
            Product product3 = new Product(2334, "pen", "blue pen", DateTime.Now.AddDays(32), 1, 25);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

        }

        public Product GetProductByName(String prod)
        {
            foreach( Product pr in products)
            {
                if (pr.Name == prod)
                    return pr;
            }
            return null;
        }

        public List<Product> FindAllProducts()
        {
            if (products.Count == 0)
                return null;
            else
                return products;
        }

        public bool AddProduct (Product prod)
        {
            if (prod != null)
            {
                products.Add(prod);
                return true;
            }
            return false;

        }

        public Product GetProductByPosition (int position)
        {
            if (position < 0 || position >= products.Count)
                throw new IndexOutOfRangeException("Position to large or to small");
            return products[position];
        }

        public bool RemoveProductByName(string productName)
        {
            foreach ( Product pr in products)
            {
                if (pr.Name == productName)
                    return products.Remove(pr);
                
            }
            return false;
        }
    }
}
