using System;
using System.Collections.Generic;

namespace AutomatedForm.Core.Entities;

public partial class TransMuniFactory
{
    public int TransId { get; set; }

    public int? MuniId { get; set; }

    public int? FactoryId { get; set; }

    public int? MatashId { get; set; }

    public int? BranchId { get; set; }

    public int? UserCreatedId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblBranch? Branch { get; set; }

    public virtual TblFactory? Factory { get; set; }

    public virtual TblMatash? Matash { get; set; }

    public virtual TblMuni? Muni { get; set; }

    public virtual TblUser? UserCreated { get; set; }
}
