namespace E_Commerce.Data.Models
{
    public class Date_Time
    {
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
    }
}
