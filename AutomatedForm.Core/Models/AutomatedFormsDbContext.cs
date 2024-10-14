using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutomatedForm.Core.Models;

public partial class AutomatedFormsDbContext : DbContext
{
    public AutomatedFormsDbContext()
    {
    }

    public AutomatedFormsDbContext(DbContextOptions<AutomatedFormsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBranch> TblBranches { get; set; }

    public virtual DbSet<TblCondition> TblConditions { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblFactory> TblFactories { get; set; }

    public virtual DbSet<TblLaboratory> TblLaboratories { get; set; }

    public virtual DbSet<TblMatash> TblMatashes { get; set; }

    public virtual DbSet<TblMuni> TblMunis { get; set; }

    public virtual DbSet<TblPriceList> TblPriceLists { get; set; }

    public virtual DbSet<TblTemplate> TblTemplates { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TransContactMany> TransContactManies { get; set; }

    public virtual DbSet<TransMuniFactory> TransMuniFactories { get; set; }

    public virtual DbSet<TransMuniLab> TransMuniLabs { get; set; }

    public virtual DbSet<TransPlan> TransPlans { get; set; }

    public virtual DbSet<TransSysLog> TransSysLogs { get; set; }

    public virtual DbSet<TransUsersMuni> TransUsersMunis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-SI8MC0H;Database=AutomatedFormsDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PK__tblBranc__A1682FA5AC1FDA58");

            entity.ToTable("tblBranch");

            entity.Property(e => e.BranchId)
                .ValueGeneratedNever()
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchDescription).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(500);
        });

        modelBuilder.Entity<TblCondition>(entity =>
        {
            entity.HasKey(e => e.ConditionId).HasName("PK__tblCondi__37F5C0EFA30387D9");

            entity.ToTable("tblCondition");

            entity.Property(e => e.ConditionId)
                .ValueGeneratedNever()
                .HasColumnName("ConditionID");
            entity.Property(e => e.ConditionJsonData).HasColumnType("text");
            entity.Property(e => e.ConditionName).HasMaxLength(500);
            entity.Property(e => e.ConditionNotes).HasMaxLength(500);
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK_tblContacts");

            entity.ToTable("tblContact");

            entity.Property(e => e.ContactId)
                .ValueGeneratedNever()
                .HasColumnName("ContactID");
            entity.Property(e => e.ContactEmail).HasMaxLength(400);
            entity.Property(e => e.ContactName).HasMaxLength(400);
            entity.Property(e => e.ContactPhone).HasMaxLength(15);
            entity.Property(e => e.ContactRole).HasMaxLength(400);
            entity.Property(e => e.Notes).HasMaxLength(400);
        });

        modelBuilder.Entity<TblFactory>(entity =>
        {
            entity.HasKey(e => e.FactoryId);

            entity.ToTable("tblFactory");

            entity.Property(e => e.FactoryId)
                .ValueGeneratedNever()
                .HasColumnName("FactoryID");
            entity.Property(e => e.FactoryAddress).HasMaxLength(400);
            entity.Property(e => e.FactoryEmail).HasMaxLength(400);
            entity.Property(e => e.FactoryName).HasMaxLength(400);
            entity.Property(e => e.FactoryPhone).HasMaxLength(15);
            entity.Property(e => e.FactoryPob)
                .HasMaxLength(10)
                .HasColumnName("FactoryPOB");
            entity.Property(e => e.Notes).HasMaxLength(400);
        });

        modelBuilder.Entity<TblLaboratory>(entity =>
        {
            entity.HasKey(e => e.LabId).HasName("PK__Laborato__238050ADECAD8BA9");

            entity.ToTable("tblLaboratory");

            entity.Property(e => e.LabId).ValueGeneratedNever();
            entity.Property(e => e.Addreess)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(400);
            entity.Property(e => e.LabName)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(525)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMatash>(entity =>
        {
            entity.HasKey(e => e.MatashId).HasName("PK__tblMatas__1C9470445A35751C");

            entity.ToTable("tblMatash");

            entity.Property(e => e.MatashId)
                .ValueGeneratedNever()
                .HasColumnName("MatashID");
            entity.Property(e => e.MatashName).HasMaxLength(500);
            entity.Property(e => e.MatashParametersJson).HasColumnType("text");
        });

        modelBuilder.Entity<TblMuni>(entity =>
        {
            entity.HasKey(e => e.MuniId);

            entity.ToTable("tblMuni");

            entity.Property(e => e.MuniId)
                .ValueGeneratedNever()
                .HasColumnName("MuniID");
            entity.Property(e => e.MuniAddress).HasMaxLength(400);
            entity.Property(e => e.MuniEmail).HasMaxLength(400);
            entity.Property(e => e.MuniLogo).HasColumnType("image");
            entity.Property(e => e.MuniName).HasMaxLength(400);
            entity.Property(e => e.MuniPhone).HasMaxLength(15);
            entity.Property(e => e.MuniPob)
                .HasMaxLength(10)
                .HasColumnName("MuniPOB");
            entity.Property(e => e.Notes).HasMaxLength(400);
        });

        modelBuilder.Entity<TblPriceList>(entity =>
        {
            entity.HasKey(e => e.PriceListId).HasName("PK__tblPrice__1E30F34C8497013F");

            entity.ToTable("tblPriceList");

            entity.Property(e => e.PriceListId)
                .ValueGeneratedNever()
                .HasColumnName("PriceListID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.PriceDetailsJson).HasColumnType("text");
            entity.Property(e => e.PriceListName).HasMaxLength(500);

            entity.HasOne(d => d.Branch).WithMany(p => p.TblPriceLists)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__tblPriceL__Branc__5165187F");
        });

        modelBuilder.Entity<TblTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PK__tblTempl__F87ADD07E0A3BF1E");

            entity.ToTable("tblTemplate");

            entity.Property(e => e.TemplateId)
                .ValueGeneratedNever()
                .HasColumnName("TemplateID");
            entity.Property(e => e.MuniId).HasColumnName("MuniID");
            entity.Property(e => e.TemplateJson).HasColumnType("text");
            entity.Property(e => e.TemplateName).HasMaxLength(500);

            entity.HasOne(d => d.Muni).WithMany(p => p.TblTemplates)
                .HasForeignKey(d => d.MuniId)
                .HasConstraintName("FK__tblTempla__MuniI__5441852A");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__tblUser__1788CCAC9DA3CD7F");

            entity.ToTable("tblUser");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.PasswordHash).HasMaxLength(500);
            entity.Property(e => e.Phone).HasMaxLength(500);
            entity.Property(e => e.PremissionJson).HasColumnType("text");
            entity.Property(e => e.UserName).HasMaxLength(500);
        });

        modelBuilder.Entity<TransContactMany>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__transCon__9E5DDB1C48CAE41E");

            entity.ToTable("transContactMany");

            entity.Property(e => e.TransId)
                .ValueGeneratedNever()
                .HasColumnName("TransID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.FactoryId).HasColumnName("FactoryID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.MuniId).HasColumnName("MuniID");
            entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");

            entity.HasOne(d => d.Contact).WithMany(p => p.TransContactManies)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK__transCont__Conta__6477ECF3");

            entity.HasOne(d => d.Factory).WithMany(p => p.TransContactManies)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK__transCont__Facto__656C112C");

            entity.HasOne(d => d.Lab).WithMany(p => p.TransContactManies)
                .HasForeignKey(d => d.LabId)
                .HasConstraintName("FK__transCont__LabID__66603565");

            entity.HasOne(d => d.Muni).WithMany(p => p.TransContactManies)
                .HasForeignKey(d => d.MuniId)
                .HasConstraintName("FK__transCont__MuniI__6383C8BA");

            entity.HasOne(d => d.UserCreated).WithMany(p => p.TransContactManies)
                .HasForeignKey(d => d.UserCreatedId)
                .HasConstraintName("FK__transCont__UserC__6754599E");
        });

        modelBuilder.Entity<TransMuniFactory>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__transMun__9E5DDB1CB089A571");

            entity.ToTable("transMuniFactory");

            entity.Property(e => e.TransId)
                .ValueGeneratedNever()
                .HasColumnName("TransID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.FactoryId).HasColumnName("FactoryID");
            entity.Property(e => e.MatashId).HasColumnName("MatashID");
            entity.Property(e => e.MuniId).HasColumnName("MuniID");
            entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");

            entity.HasOne(d => d.Branch).WithMany(p => p.TransMuniFactories)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__transMuni__Branc__5AEE82B9");

            entity.HasOne(d => d.Factory).WithMany(p => p.TransMuniFactories)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK__transMuni__Facto__59063A47");

            entity.HasOne(d => d.Matash).WithMany(p => p.TransMuniFactories)
                .HasForeignKey(d => d.MatashId)
                .HasConstraintName("FK__transMuni__Matas__59FA5E80");

            entity.HasOne(d => d.Muni).WithMany(p => p.TransMuniFactories)
                .HasForeignKey(d => d.MuniId)
                .HasConstraintName("FK__transMuni__MuniI__5812160E");

            entity.HasOne(d => d.UserCreated).WithMany(p => p.TransMuniFactories)
                .HasForeignKey(d => d.UserCreatedId)
                .HasConstraintName("FK__transMuni__UserC__5BE2A6F2");
        });

        modelBuilder.Entity<TransMuniLab>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__transMun__9E5DDB1C5B5E4569");

            entity.ToTable("transMuniLab");

            entity.Property(e => e.TransId)
                .ValueGeneratedNever()
                .HasColumnName("TransID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.MuniId).HasColumnName("MuniID");
            entity.Property(e => e.PriceDetailsJson).HasColumnType("text");
            entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");

            entity.HasOne(d => d.Lab).WithMany(p => p.TransMuniLabs)
                .HasForeignKey(d => d.LabId)
                .HasConstraintName("FK__transMuni__LabID__5FB337D6");

            entity.HasOne(d => d.Muni).WithMany(p => p.TransMuniLabs)
                .HasForeignKey(d => d.MuniId)
                .HasConstraintName("FK__transMuni__MuniI__5EBF139D");

            entity.HasOne(d => d.UserCreated).WithMany(p => p.TransMuniLabs)
                .HasForeignKey(d => d.UserCreatedId)
                .HasConstraintName("FK__transMuni__UserC__60A75C0F");
        });

        modelBuilder.Entity<TransPlan>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__transPla__9E5DDB1C68ED6EEF");

            entity.ToTable("transPlan");

            entity.Property(e => e.TransId)
                .ValueGeneratedNever()
                .HasColumnName("TransID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.MuniId).HasColumnName("MuniID");
            entity.Property(e => e.PlanDetails).HasColumnType("text");
            entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");

            entity.HasOne(d => d.Muni).WithMany(p => p.TransPlans)
                .HasForeignKey(d => d.MuniId)
                .HasConstraintName("FK__transPlan__MuniI__74AE54BC");

            entity.HasOne(d => d.UserCreated).WithMany(p => p.TransPlans)
                .HasForeignKey(d => d.UserCreatedId)
                .HasConstraintName("FK__transPlan__UserC__75A278F5");
        });

        modelBuilder.Entity<TransSysLog>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__transSys__9E5DDB1C807BD083");

            entity.ToTable("transSysLog");

            entity.Property(e => e.TransId)
                .ValueGeneratedNever()
                .HasColumnName("TransID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.LogDetails).HasColumnType("text");
            entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.UserCreated).WithMany(p => p.TransSysLogUserCreateds)
                .HasForeignKey(d => d.UserCreatedId)
                .HasConstraintName("FK__transSysL__UserC__71D1E811");

            entity.HasOne(d => d.User).WithMany(p => p.TransSysLogUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__transSysL__UserI__70DDC3D8");
        });

        modelBuilder.Entity<TransUsersMuni>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__transUse__9E5DDB1C8FD3FCAD");

            entity.ToTable("transUsersMuni");

            entity.Property(e => e.TransId)
                .ValueGeneratedNever()
                .HasColumnName("TransID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.FactoryId).HasColumnName("FactoryID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.MuniId).HasColumnName("MuniID");
            entity.Property(e => e.Pdflocation)
                .HasMaxLength(500)
                .HasColumnName("PDFLocation");
            entity.Property(e => e.PrivilegeJson).HasColumnType("text");
            entity.Property(e => e.SimulatorLocation).HasMaxLength(500);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.UserCreatedId).HasColumnName("UserCreatedID");

            entity.HasOne(d => d.Factory).WithMany(p => p.TransUsersMunis)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK__transUser__Facto__6C190EBB");

            entity.HasOne(d => d.Lab).WithMany(p => p.TransUsersMunis)
                .HasForeignKey(d => d.LabId)
                .HasConstraintName("FK__transUser__LabID__6D0D32F4");

            entity.HasOne(d => d.Muni).WithMany(p => p.TransUsersMunis)
                .HasForeignKey(d => d.MuniId)
                .HasConstraintName("FK__transUser__MuniI__6A30C649");

            entity.HasOne(d => d.Template).WithMany(p => p.TransUsersMunis)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("FK__transUser__Templ__6B24EA82");

            entity.HasOne(d => d.UserCreated).WithMany(p => p.TransUsersMunis)
                .HasForeignKey(d => d.UserCreatedId)
                .HasConstraintName("FK__transUser__UserC__6E01572D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
