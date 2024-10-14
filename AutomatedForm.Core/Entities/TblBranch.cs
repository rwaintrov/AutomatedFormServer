using System;
using System.Collections.Generic;

namespace AutomatedForm.Core.Entities;

public partial class TblBranch
{
    public int BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchDescription { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<TblPriceList> TblPriceLists { get; set; } = new List<TblPriceList>();

    public virtual ICollection<TransMuniFactory> TransMuniFactories { get; set; } = new List<TransMuniFactory>();
}
