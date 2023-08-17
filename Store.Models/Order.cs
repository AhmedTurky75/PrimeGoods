using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Order : BaseEntity
    {
        public DateTime Date { get; set; }
        public float TotalPrice { get; set; }
        public int ItemsCount { get; set; }

        [ForeignKey("Buyer")]
        public long BuyerID { get; set; }
        public Buyer Buyer { get; set; }

        [ForeignKey("Coupon")]
        public long CouponID { get; set; }
        public Coupon Coupon { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}