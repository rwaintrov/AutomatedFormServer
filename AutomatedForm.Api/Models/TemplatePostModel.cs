namespace AutomatedForm.Api.Models
{
    public class TemplatePostModel
    {
        public int TemplateId { get; set; }

        public int? MuniId { get; set; }

        public string? TemplateName { get; set; }

        public string? TemplateJson { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Notes { get; set; }
    }
}
