namespace AutomatedForm.Api.Models
{
    public class MuniLabPostModel
    {
        public int TransId { get; set; }

        public int? MuniId { get; set; }

        public int? LabId { get; set; }

        public int? UserCreatedId { get; set; }

        public DateTime? DateCreated { get; set; }

        public string? PriceDetailsJson { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Notes { get; set; }
    }
}
