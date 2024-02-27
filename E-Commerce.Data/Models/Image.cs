using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Data.Models
{
    public class Image:Date_Time
    {
        public int? Id { get; set; }
        public string? Path { get; set; }
        public float? Size { get; set; }
        public string? Extension { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }        

    }
}
