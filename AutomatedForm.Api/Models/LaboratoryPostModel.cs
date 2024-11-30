namespace AutomatedForm.Api.Models
{
    public class LaboratoryPostModel
    {
        public int LabId { get; set; }

        public string? LabName { get; set; }

        public string? Addreess { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDelete { get; set; }

        public string? Note { get; set; }

        public string? Email { get; set; }
    }
}
