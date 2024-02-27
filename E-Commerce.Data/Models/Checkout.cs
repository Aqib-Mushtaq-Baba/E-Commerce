using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Data.Models
{
    public class Checkout:Date_Time
    {
        public int? Id { get; set; }
        public int? TotalPrice { get; set; }


        [ForeignKey(nameof(ApplicationUser))]
        public string? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        

        [ForeignKey(nameof(Address))]
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
