using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DemoDatabaseFirst.Model;

public partial class MyStore1Context : DbContext
{
    public MyStore1Context()
    {
    }

    public MyStore1Context(DbContextOptions<MyStore1Context> options) : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
          optionsBuilder.UseSqlServer("Data Source=HORSETUS;Database=MyStore1;User Id=sa;Password=12345;TrustServerCertificate=true;Trusted_Connection=SSPI;Encrypt=false;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relation:Collation", "SQL_Latin1_CP1_CI_AS");
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
            .IsRequired()
            .HasMaxLength(15)
            .UseCollation("Vietnamese_CI_AS");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductId).HasColumnName("ProductID");            
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(40)
                .UseCollation("Vietnamese_CI_AS");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_Categories");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
