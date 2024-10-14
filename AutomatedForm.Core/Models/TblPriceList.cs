using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutomatedForm.Core.Models;

public partial class TblPriceList
{
    [Key]
    public int PriceListId { get; set; }

    public int? BranchId { get; set; }

    public string? PriceListName { get; set; }

    public string? PriceDetailsJson { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblBranch? Branch { get; set; }
}
