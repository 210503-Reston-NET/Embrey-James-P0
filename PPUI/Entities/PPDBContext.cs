using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PPUI.Entities
{
    public partial class PPDBContext : DbContext
    {
        public PPDBContext()
        {
        }

        public PPDBContext(DbContextOptions<PPDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Sauce> Sauces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:patricks-peppers-net.database.windows.net,1433;Initial Catalog=PPDB;Persist Security Info=False;User ID=dbadmin;Password=Mbreonix@88;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddDate)
                    .HasColumnType("date")
                    .HasColumnName("addDate");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("customerName");
            });

            modelBuilder.Entity<Sauce>(entity =>
            {
                entity.ToTable("Sauce");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SauceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sauceName");

                entity.Property(e => e.SaucePrice).HasColumnName("saucePrice");

                entity.Property(e => e.SauceTemp)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sauceTemp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
