using System;
using System.ComponentModel.DataAnnotations;

namespace Laborator.ViewModel
{
    public class CityViewModel
    {
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
