namespace E_Commerce.Data.Models
{
    public class ProductCategory:Date_Time
    {
        public int? Id { get; set; }
        public string? Category { get; set; }

        ICollection<Product>? Products { get; set; }
    }
}
