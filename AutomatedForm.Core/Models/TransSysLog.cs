﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutomatedForm.Core.Models;

public partial class TransSysLog
{
    [Key]
    public int TransId { get; set; }

    public int? UserId { get; set; }

    public int? UserCreatedId { get; set; }

    public string? LogDetails { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual TblUser? User { get; set; }

    public virtual TblUser? UserCreated { get; set; }
}