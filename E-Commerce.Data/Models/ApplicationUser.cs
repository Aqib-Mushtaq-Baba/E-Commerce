using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Data.Models
{
    public class ApplicationUser:IdentityUser
    {
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string? ProfilePath { get; set; }

        public ICollection<Product>? Products { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
        
    }
}
