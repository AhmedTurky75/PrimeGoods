namespace Store.Models
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Buyer> Buyers { get; set; }
        public ICollection<Coupon> Coupons { get; set; }

    }
}