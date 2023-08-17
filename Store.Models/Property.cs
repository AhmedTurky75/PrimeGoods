namespace Store.Models
{
    public class Property : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<ProductProperties> ProductProperties { get; set; }

    }
}