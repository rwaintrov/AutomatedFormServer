using System;
using System.Collections.Generic;

namespace AutomatedForm.Api.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? PremissionJson { get; set; }

    public string? Phone { get; set; }

    public string? PasswordHash { get; set; }

    public string? Email { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<TransContactMany> TransContactManies { get; set; } = new List<TransContactMany>();

    public virtual ICollection<TransMuniFactory> TransMuniFactories { get; set; } = new List<TransMuniFactory>();

    public virtual ICollection<TransMuniLab> TransMuniLabs { get; set; } = new List<TransMuniLab>();

    public virtual ICollection<TransPlan> TransPlans { get; set; } = new List<TransPlan>();

    public virtual ICollection<TransSysLog> TransSysLogUserCreateds { get; set; } = new List<TransSysLog>();

    public virtual ICollection<TransSysLog> TransSysLogUsers { get; set; } = new List<TransSysLog>();

    public virtual ICollection<TransUsersMuni> TransUsersMunis { get; set; } = new List<TransUsersMuni>();
}
