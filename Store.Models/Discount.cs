using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Discount : BaseEntity
    {
        [ForeignKey("Seller")]
        public long SellerId { get; set; }
        public Seller Seller { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}