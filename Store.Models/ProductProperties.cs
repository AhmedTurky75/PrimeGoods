using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class ProductProperties
    {
        [ForeignKey("Product")]

        public long ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Properties")]

        public long PropertiesId { get; set; }
        public Property Properties { get; set; }
        public string Value { get; set; }

    }
}