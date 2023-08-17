using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class BuyerProductReview
    {
        [ForeignKey("Product")]
        public long ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Buyer")]
        public long BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public float Rate { get; set; }
        public string Comment { get; set; }

    }
}
