using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class Customer
    {
        
        
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }

        [RegularExpression(@"40+0\d{9}$")]
        public string PhoneNumber { get; set; }
        
        [RegularExpression(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}")]
        public string Email { get; set; }
        
    }
}