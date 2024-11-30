//using AutomatedForm.Core.Entities;
using AutomatedForm.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Data
{
    public class DataContext:DbContext
    {
        //public DbSet<Form> Forms { get; set; }
        public DbSet<TblBranch> TblBranch{ get; set; }
        public DbSet<TblTemplate> TblTemplate { get; set; }
        public DbSet<TblMuni> TblMuni { get; set; }
        public DbSet<TblFactory> TblFactory { get; set; }
        public DbSet<TransMuniFactory> TransMuniFactory { get; set; }

        public DbSet<TransMuniLab> TransMuniLab { get; set; }
        public DbSet<TblLaboratory> TblLaboratory { get; set; }



        public DbSet<TblUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBranch>()
                .HasKey(pe => new { pe.BranchId,});
                base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<TblTemplate>()
                           .HasKey(pe => new { pe.TemplateId,});
                           base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TblMuni>()
                                       .HasKey(pe => new { pe.MuniId,});
                                       base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TblFactory>()
                                      .HasKey(pe => new { pe.FactoryId, });
            base.OnModelCreating(modelBuilder);

modelBuilder.Entity<TransMuniFactory>()
                                      .HasKey(pe => new { pe.TransId, });
            base.OnModelCreating(modelBuilder);




modelBuilder.Entity<TransMuniLab>()
                                      .HasKey(pe => new { pe.TransId, });
            base.OnModelCreating(modelBuilder);

            
            
            
            
            
            modelBuilder.Entity<TblLaboratory>()
             .HasKey(pe => new { pe.LabId, });
            base.OnModelCreating(modelBuilder);










            modelBuilder.Entity<TblUser>()
                .HasMany(u => u.TransSysLogUserCreateds)
                .WithOne(t => t.UserCreated)  // שנה זאת לשם הנכון של המאפיין ב-TransSysLog
                .HasForeignKey(t => t.UserCreatedId);  // שנה זאת למפתח הזר המתאים ב-TransSysLog
        
        }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-SI8MC0H;InitialCatalog=AutomatedFormsDB;Integrated Security=True;Encrypt=False");
            optionsBuilder.UseSqlServer("Server=DESKTOP-SI8MC0H;Database=AutomatedFormsDB;Integrated Security=True;Encrypt=False");
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DB_AutomatedForm");
        }
    }
}
