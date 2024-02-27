namespace E_Commerce.Data.Models
{
    public class Brand:Date_Time
    {
        public int? Id { get; set; }
        public string? BrandName { get; set; }

        ICollection<Product>? Products { get; set; }
    }
}
