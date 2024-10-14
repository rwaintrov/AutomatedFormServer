using System;
using System.Collections.Generic;

namespace AutomatedForm.Core.Entities;

public partial class TransPlan
{
    public int TransId { get; set; }

    public int? MuniId { get; set; }

    public int? UserCreatedId { get; set; }

    public int? TheYear { get; set; }

    public bool? IsFinal { get; set; }

    public string? PlanDetails { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblMuni? Muni { get; set; }

    public virtual TblUser? UserCreated { get; set; }
}
