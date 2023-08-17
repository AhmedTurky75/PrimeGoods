using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedOn { get; set; }

        [ForeignKey("CreatedBy")]
        public long? CreatedByID { get; set; }
        public User? CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        [ForeignKey("UpdatedBy")]
        public long? UpdatedByID { get; set; }
        public User? UpdatedBy { get; set; }

    }
}
