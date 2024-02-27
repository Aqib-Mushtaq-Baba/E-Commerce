using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Data.Models
{
    public class Rating:Date_Time
    {
        public int? Id { get; set; }
        public string? Ratings { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set;}
        public Product? Product { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
