namespace AutomatedForm.Api.Models
{
    public class MuniPostModel
    {
        public int MuniId { get; set; }

        public string? MuniName { get; set; }

        public byte[]? MuniLogo { get; set; }

        public string? MuniAddress { get; set; }

        public string? MuniPhone { get; set; }

        public string? MuniEmail { get; set; }

        public string? MuniPob { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Notes { get; set; }

    }
}
