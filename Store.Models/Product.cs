using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public string ImgURL { get; set; }
        public float Price { get; set; }
        public bool IsBestSeller { get; set; }
        public float Rate { get; set; }

        [ForeignKey("SubCategory")]
        public long SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        [ForeignKey("Brand")]
        public long BrandId { get; set; }
        public Brand Brand { get; set; }

        [ForeignKey("Seller")]
        public long SellerId { get; set; }
        public Seller Seller { get; set; }

        public ICollection<ProductProperties> ProductProperties { get; set; }
        public ICollection<BuyerCart> BuyerCarts { get; set; }
        public ICollection<BuyerProductReview> Reviews { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Buyer> BuyerFavourites { get; set; }
        public ICollection<Discount> Discounts { get; set; }



    }
}