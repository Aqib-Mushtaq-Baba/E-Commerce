using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Data.Models
{
    public class ProductSubCategory:Date_Time
    {
        public int? Id { get; set; }
        public string? SubCategory { get; set; }
        
        ICollection<Product>? Products { get; set; }

        [ForeignKey("ProductCategory")]
        public int? CategoryId { get; set; }
        public ProductCategory? ProductCategory { get; set; }
    }
}
