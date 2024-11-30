using System;
using System.Collections.Generic;

namespace AutomatedForm.Api.Models;

public partial class TblMatash
{
    public int MatashId { get; set; }

    public string? MatashName { get; set; }

    public string? MatashParametersJson { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<TransMuniFactory> TransMuniFactories { get; set; } = new List<TransMuniFactory>();
}
