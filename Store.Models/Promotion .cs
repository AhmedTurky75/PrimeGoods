using static Store.Utility.Enums;

namespace Store.Models
{
    public class Promotion : BaseEntity
    {
        public string Code { get; set; }
        public int UsageLimit { get; set; }
        public long Discount { get; set; }

        public DiscountType DiscountType { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}