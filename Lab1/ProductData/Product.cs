using System;

namespace ProductData
{
    public class Product
    {
        public Product(int id,string name, string description, DateTime startDate, double price, int vat)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = DateTime.Now;
            Price = price;
            VAT = vat;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public double Price { get; private set; }

        public int VAT { get; private set; }

        public bool IsValid()
        {
            if(StartDate>EndDate)
                    return false;
                else 
                    return true;
        }

        public double ComputeVAT()
        {
            return Price*VAT/100;
        }
    }
}
