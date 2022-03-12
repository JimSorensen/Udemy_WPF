using System;
using Gruppe1_Assignment_1_F22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Gruppe1_Assignment_1_F22.DB
{
    public partial class Gruppe1_DebtBookContext : DbContext
    {
        public Gruppe1_DebtBookContext(DbContextOptions<Gruppe1_DebtBookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public Gruppe1_DebtBookContext()
        {
        }
        
        public DbSet<EmployeeDetailModel> employeeDetailModels { get; set; }
    }
}

// "Server=mysql73.unoeuro.com;Port=3306; Allow Zero Datetime=True; Convert Zero Datetime=True; Database = softwarejs_com_db; Uid = softwarejs_com; Pwd = dyhEH6fw3kaR"
// Server = myServerAddress; Port = 1234; Database = myDataBase; Uid = myUsername; Pwd = myPassword;

/*
 
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WPF_EF_ScaffoldDbContext.Models
{
    public partial class WPF_DBContext : DbContext
    {
        public WPF_DBContext()
        {
        }

        public WPF_DBContext(DbContextOptions<WPF_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCountry> TblCountries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(Properties.Settings.Default.WPF_Connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__tblCount__D320769CD978EC60");

                entity.ToTable("tblCountry");

                entity.Property(e => e.CountryId).HasColumnName("countryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("countryName");

                entity.Property(e => e.Greeting)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("greeting");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

 */