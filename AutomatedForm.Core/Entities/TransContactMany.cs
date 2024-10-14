using System;
using System.Collections.Generic;

namespace AutomatedForm.Core.Entities;

public partial class TransContactMany
{
    public int TransId { get; set; }

    public int? MuniId { get; set; }

    public int? ContactId { get; set; }

    public int? FactoryId { get; set; }

    public int? LabId { get; set; }

    public int? UserCreatedId { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblContact? Contact { get; set; }

    public virtual TblFactory? Factory { get; set; }

    public virtual TblLaboratory? Lab { get; set; }

    public virtual TblMuni? Muni { get; set; }

    public virtual TblUser? UserCreated { get; set; }
}
