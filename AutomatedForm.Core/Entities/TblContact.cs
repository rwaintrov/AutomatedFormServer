using System;
using System.Collections.Generic;

namespace AutomatedForm.Core.Entities;

public partial class TblContact
{
    public int ContactId { get; set; }

    public string? ContactName { get; set; }

    public string? ContactRole { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactEmail { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<TransContactMany> TransContactManies { get; set; } = new List<TransContactMany>();
}
