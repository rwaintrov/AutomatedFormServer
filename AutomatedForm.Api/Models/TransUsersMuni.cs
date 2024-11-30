using System;
using System.Collections.Generic;

namespace AutomatedForm.Api.Models;

public partial class TransUsersMuni
{
    public int TransId { get; set; }

    public int? MuniId { get; set; }

    public int? TemplateId { get; set; }

    public int? FactoryId { get; set; }

    public int? LabId { get; set; }

    public int? UserCreatedId { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? LetterText { get; set; }

    public string? Pdflocation { get; set; }

    public string? SimulatorLocation { get; set; }

    public string? PrivilegeJson { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblFactory? Factory { get; set; }

    public virtual TblLaboratory? Lab { get; set; }

    public virtual TblMuni? Muni { get; set; }

    public virtual TblTemplate? Template { get; set; }

    public virtual TblUser? UserCreated { get; set; }
}
