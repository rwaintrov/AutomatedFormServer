﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutomatedForm.Core.Models;
public partial class TransMuniLab
{
    [Key]
    public int TransId { get; set; }

    public int? MuniId { get; set; }

    public int? LabId { get; set; }

    public int? UserCreatedId { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? PriceDetailsJson { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblLaboratory? Lab { get; set; }

    public virtual TblMuni? Muni { get; set; }

    public virtual TblUser? UserCreated { get; set; }
}