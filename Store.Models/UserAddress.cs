using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class UserAddress
    {
        [ForeignKey("User")]
        public long UserId { get; set; }
        public User User { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int? BuildingNo { get; set; }
        public int? Floor { get; set; }
        public int? ZipCode { get; set; }
    }
}