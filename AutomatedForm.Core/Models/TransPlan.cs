using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutomatedForm.Core.Models;

public partial class TransPlan
{
    [Key]
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
