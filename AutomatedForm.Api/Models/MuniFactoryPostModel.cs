namespace AutomatedForm.Api.Models
{
    public class MuniFactoryPostModel
    {
        public int TransId { get; set; }

        public int? MuniId { get; set; }

        public int? FactoryId { get; set; }

        public int? MatashId { get; set; }

        public int? BranchId { get; set; }

        public int? UserCreatedId { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Notes { get; set; }
    }
}
