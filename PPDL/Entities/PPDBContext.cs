using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PPDL.Entities
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
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.CustomerLocale)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("customerLocale");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.CustomerQuantity).HasColumnName("customerQuantity");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.LocationCity)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("locationCity");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("locationName");

                entity.Property(e => e.LocationState)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("locationState");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.ManagerId).HasColumnName("managerID");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("managerName");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("orderID");

                entity.Property(e => e.OrderNumber).HasColumnName("orderNumber");

                entity.Property(e => e.OrderQuantity).HasColumnName("orderQuantity");

                entity.HasOne(d => d.OrderNumberNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderNumber)
                    .HasConstraintName("FK__Orders__orderNum__44952D46");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductQuantity).HasColumnName("productQuantity");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreId).HasColumnName("storeID");

                entity.Property(e => e.StoreLocation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("storeLocation");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("storeName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
