using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.DTOs
{
    public class BranchDTO
    {
        public int BranchId { get; set; }

        public string? BranchName { get; set; }

        public string? BranchDescription { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Notes { get; set; }
    }
}
