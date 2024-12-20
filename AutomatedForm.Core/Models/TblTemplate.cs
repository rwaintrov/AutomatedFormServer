﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomatedForm.Core.Models;

public partial class TblTemplate
{
    [Key]
    public int TemplateId { get; set; }

    public int? MuniId { get; set; }

    public string? TemplateName { get; set; }

    public string? TemplateJson { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblMuni? Muni { get; set; }

    public virtual ICollection<TransUsersMuni> TransUsersMunis { get; set; } = new List<TransUsersMuni>();
}
