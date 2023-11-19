using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CostsCalculator.Data;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ITEMS> ITEMS { get; set; }

    public virtual DbSet<ITEMS_DEV> ITEMS_DEV { get; set; }

    public virtual DbSet<PRODUCTS> PRODUCTS { get; set; }

    public virtual DbSet<PRODUCTS_DEV> PRODUCTS_DEV { get; set; }

    public virtual DbSet<USERS> USERS { get; set; }

    public virtual DbSet<USERS_DEV> USERS_DEV { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("User Id=ADMIN;Password=&|s*ckHd51.$zb0:fJB$;Data Source=(description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.eu-paris-1.oraclecloud.com))(connect_data=(service_name=g429f0287593741_costscalculator_high.adb.oraclecloud.com))(security=(ssl_server_dn_match=yes)));Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("ADMIN")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<ITEMS>(entity =>
        {
            entity.HasKey(e => e.ITEM_ID).HasName("SYS_C0035682");

            entity.Property(e => e.ITEM_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_BUY_PRICE).HasColumnType("NUMBER(10,2)");
            entity.Property(e => e.ITEM_BUY_QUANTITY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_BUY_UNIT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ITEM_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ITEM_PRODUCT_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_USE_PRICE).HasColumnType("NUMBER(10,2)");
            entity.Property(e => e.ITEM_USE_QUANTITY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_USE_UNIT)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ITEM_PRODUCT).WithMany(p => p.ITEMS)
                .HasForeignKey(d => d.ITEM_PRODUCT_ID)
                .HasConstraintName("FK_ITEM_PRODUCT");
        });

        modelBuilder.Entity<ITEMS_DEV>(entity =>
        {
            entity.HasKey(e => e.ITEM_ID).HasName("SYS_C0035695");

            entity.Property(e => e.ITEM_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_BUY_PRICE).HasColumnType("NUMBER(10,2)");
            entity.Property(e => e.ITEM_BUY_QUANTITY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_BUY_UNIT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ITEM_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ITEM_PRODUCT_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_USE_PRICE).HasColumnType("NUMBER(10,2)");
            entity.Property(e => e.ITEM_USE_QUANTITY).HasColumnType("NUMBER(38)");
            entity.Property(e => e.ITEM_USE_UNIT)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ITEM_PRODUCT).WithMany(p => p.ITEMS_DEV)
                .HasForeignKey(d => d.ITEM_PRODUCT_ID)
                .HasConstraintName("FK_ITEM_PRODUCT_DEV");
        });

        modelBuilder.Entity<PRODUCTS>(entity =>
        {
            entity.HasKey(e => e.PRODUCT_ID).HasName("SYS_C0035679");

            entity.Property(e => e.PRODUCT_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.PRODUCT_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PRODUCT_USER_ID).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.PRODUCT_USER).WithMany(p => p.PRODUCTS)
                .HasForeignKey(d => d.PRODUCT_USER_ID)
                .HasConstraintName("FK_PRODUCT_USER");
        });

        modelBuilder.Entity<PRODUCTS_DEV>(entity =>
        {
            entity.HasKey(e => e.PRODUCT_ID).HasName("SYS_C0035692");

            entity.Property(e => e.PRODUCT_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.PRODUCT_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PRODUCT_USER_ID).HasColumnType("NUMBER(38)");

            entity.HasOne(d => d.PRODUCT_USER).WithMany(p => p.PRODUCTS_DEV)
                .HasForeignKey(d => d.PRODUCT_USER_ID)
                .HasConstraintName("FK_PRODUCT_USER_DEV");
        });

        modelBuilder.Entity<USERS>(entity =>
        {
            entity.HasKey(e => e.USER_ID).HasName("SYS_C0035677");

            entity.Property(e => e.USER_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.USER_EMAIL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.USER_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USER_PASSWORD)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<USERS_DEV>(entity =>
        {
            entity.HasKey(e => e.USER_ID).HasName("SYS_C0035686");

            entity.Property(e => e.USER_ID).HasColumnType("NUMBER(38)");
            entity.Property(e => e.USER_EMAIL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.USER_NAME)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USER_PASSWORD)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
