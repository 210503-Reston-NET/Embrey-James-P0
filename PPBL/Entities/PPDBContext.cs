using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PPBL.Entities
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
