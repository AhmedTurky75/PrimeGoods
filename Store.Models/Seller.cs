using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Seller //: BaseEntity
    {
        [Key, ForeignKey("User"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }
        public User User { get; set; }
        public string? StorePolicy { get; set; }
        public string? StoreDescription { get; set; }
        public string? StoreLogoURL { get; set; }
        public string? StoreName { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Discount> Discounts { get; set; }

    }
}