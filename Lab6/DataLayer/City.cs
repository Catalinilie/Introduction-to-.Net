using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Data
{
    public class City
    {
        public Guid Id { get;  set; }

        [StringLength(150, MinimumLength = 50)]
        public String Name { get;  set; }

        public String Description { get;  set; }

        public Double Latitude { get;  set; }

        public Double Longitude { get;  set; }

       
    }
}
