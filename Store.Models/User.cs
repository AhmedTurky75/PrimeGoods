namespace Store.Models
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? ImgURL { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public float? Balance { get; set; }
    }
}