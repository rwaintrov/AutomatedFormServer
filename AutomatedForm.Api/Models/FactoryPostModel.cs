namespace AutomatedForm.Api.Models
{
    public class FactoryPostModel
    {
        public int FactoryId { get; set; }

        public string? FactoryName { get; set; }

        public string? FactoryAddress { get; set; }

        public string? FactoryPhone { get; set; }

        public string? FactoryEmail { get; set; }

        public string? FactoryPob { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Notes { get; set; }
    }
}
