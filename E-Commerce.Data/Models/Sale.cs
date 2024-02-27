using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Data.Models
{
    public class Sale:Date_Time
    {
        public int? Id { get; set; }
        public int? SaleQuantity { get; set; }


        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }


        [ForeignKey(nameof(ApplicationUser))]
        public string? BuyerId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
