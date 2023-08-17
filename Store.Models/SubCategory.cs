using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class SubCategory : BaseEntity
    {
        public string? Name { get; set; }

        [ForeignKey("Category")]
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Property> Properties { get; set; }


    }
}