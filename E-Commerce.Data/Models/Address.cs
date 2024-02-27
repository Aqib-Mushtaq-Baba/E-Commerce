using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Data.Models
{
    public class Address
    {
        public int? Id { get; set; }
        public int? Pincode { get; set; }
        public string? State { get; set; }
        public string? FullAddress { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
