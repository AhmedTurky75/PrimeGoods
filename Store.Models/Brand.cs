namespace Store.Models
{
    public class Brand : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string ImgURL { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
