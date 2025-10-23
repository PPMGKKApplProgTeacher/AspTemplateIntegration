using System.ComponentModel.DataAnnotations;

namespace ApartmentsListingDemo.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
        public string Image { get; set; }
    }
}
