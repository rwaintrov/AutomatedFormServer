using System;
using System.Collections.Generic;

namespace AutomatedForm.Api.Models;

public partial class TblMuni
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

    public virtual ICollection<TblTemplate> TblTemplates { get; set; } = new List<TblTemplate>();

    public virtual ICollection<TransContactMany> TransContactManies { get; set; } = new List<TransContactMany>();

    public virtual ICollection<TransMuniFactory> TransMuniFactories { get; set; } = new List<TransMuniFactory>();

    public virtual ICollection<TransMuniLab> TransMuniLabs { get; set; } = new List<TransMuniLab>();

    public virtual ICollection<TransPlan> TransPlans { get; set; } = new List<TransPlan>();

    public virtual ICollection<TransUsersMuni> TransUsersMunis { get; set; } = new List<TransUsersMuni>();
}
