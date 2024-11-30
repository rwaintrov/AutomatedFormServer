using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.DTOs
{
    public class LaboratoryDTO
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
