using System;
using System.Collections.Generic;

namespace AutomatedForm.Core.Entities;

public partial class TblCondition
{
    public int ConditionId { get; set; }

    public string? ConditionName { get; set; }

    public string? ConditionJsonData { get; set; }

    public string? ConditionNotes { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }
}
