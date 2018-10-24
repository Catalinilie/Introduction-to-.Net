using System;
using ClassLibrary1;

namespace UsingEF
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagement prod = new ProductManagement();
            var repository = new ProductRepository(prod);

            var entity = new Product()
            {
                Id = Guid.NewGuid(),
                Name =  "Bike",
                Description = "Blue bike",
                StartDate = DateTime.Now.AddDays(-123),
                Price = 123.0,
                VAT = 24
            };
            var entity2 = new Product()
            {
                Id = Guid.NewGuid(),
                Name =  "Pen",
                Description = "Black pen",
                StartDate = DateTime.Now.AddDays(-1223),
                Price = 3.0,
                VAT = 24
            };

            repository.Create(entity);
            repository.Create(entity2);
            entity.Description = "Test";
            repository.Update(entity);
            repository.Delete(entity2);
        }
    }
}