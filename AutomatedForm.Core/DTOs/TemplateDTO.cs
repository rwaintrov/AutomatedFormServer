﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.DTOs
{
    public class TemplateDTO
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
