using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ApartmentsListingDemo.Models
{
    public class Listing
    {
        [Key]
        public int id { get; set; }
        public string Image { get; set;  }
        public string Title { get; set; }
        public string Agent { get; set; }
        public string Rent { get; set; }
        public double Size { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public Category? Category { get; set; }
    }
}
