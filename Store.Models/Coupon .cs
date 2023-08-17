namespace Store.Models
{
    public class Coupon : BaseEntity
    {
        public float MinimumPurchaseAmount { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}