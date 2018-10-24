using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class Product
    {
//        public Product(Guid id, string name, string description, DateTime startDate, double price, int vat)
//        {
//            Id = id;
//            Name = name;
//            Description = description;
//            StartDate = startDate;
//            EndDate = DateTime.Now;
//            Price = price;
//            VAT = vat;
//        }

        public Guid Id { get;  set; }

        [StringLength(50)]
        public string Name { get;  set; }

        public string Description { get;  set; }

        [Required]
        public DateTime StartDate { get;  set; }

        public DateTime? EndDate { get;  set; }

        [Required]
        public double Price { get;  set; }

        [Required]
        public int VAT { get;  set; }

        public bool IsValid()
        {
            if (StartDate > EndDate)
                return false;
            else
                return true;
        }

        public double ComputeVAT()
        {
            return Price * VAT / 100;
        }
    }
}