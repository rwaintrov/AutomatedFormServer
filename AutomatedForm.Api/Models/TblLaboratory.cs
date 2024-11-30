using System;
using System.Collections.Generic;

namespace AutomatedForm.Api.Models;

public partial class TblLaboratory
{
    public int LabId { get; set; }

    public string? LabName { get; set; }

    public string? Addreess { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDelete { get; set; }

    public string? Note { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<TransContactMany> TransContactManies { get; set; } = new List<TransContactMany>();

    public virtual ICollection<TransMuniLab> TransMuniLabs { get; set; } = new List<TransMuniLab>();

    public virtual ICollection<TransUsersMuni> TransUsersMunis { get; set; } = new List<TransUsersMuni>();
}
