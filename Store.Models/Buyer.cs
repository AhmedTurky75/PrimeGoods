using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Buyer //: BaseEntity
    {
        [Key, ForeignKey("User"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UserId { get; set; }
        public User User { get; set; }
        public ICollection<BuyerCart> BuyerCarts { get; set; }
        public ICollection<BuyerProductReview> Reviews { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> FavProducts { get; set; }
        public ICollection<Group> Groups { get; set; }


    }
}
