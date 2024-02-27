using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Data.Models
{
    public class Product:Date_Time
    {
        public int? Id { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }        
        public int? ProductQuantity { get; set; }
        public int? Price { get; set; }

        ICollection<Rating>? Rating { get; set; }

        [ForeignKey(nameof(ProductCategory))]
        public int? ProductCategoryId { get; set; }
        public ProductCategory? ProductCategory { get; set; }


        [ForeignKey("ProductSubCategory")]
        public int? SubCategoryId { get; set; }
        public ProductSubCategory? SubCategory { get; set; }


        [ForeignKey(nameof(Brand))]
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }

        ICollection<Image>? Images { get; set; }
        ICollection<Sale>? Sales { get; set; }
    }
}
