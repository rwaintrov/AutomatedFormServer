using System;
using System.Collections.Generic;

namespace AutomatedForm.Core.Entities;

public partial class TblFactory
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

    public virtual ICollection<TransContactMany> TransContactManies { get; set; } = new List<TransContactMany>();

    public virtual ICollection<TransMuniFactory> TransMuniFactories { get; set; } = new List<TransMuniFactory>();

    public virtual ICollection<TransUsersMuni> TransUsersMunis { get; set; } = new List<TransUsersMuni>();
}
