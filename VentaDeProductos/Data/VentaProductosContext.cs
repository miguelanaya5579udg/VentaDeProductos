using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VentaDeProductos.Models;

namespace VentaDeProductos.Data;

public partial class VentaProductosContext : DbContext
{
    public VentaProductosContext()
    {
    }

    public VentaProductosContext(DbContextOptions<VentaProductosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Catpersonal> Catpersonals { get; set; }

    public virtual DbSet<Catproducto> Catproductos { get; set; }

    public virtual DbSet<Tblinventario> Tblinventarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=Venta_de_Productos;user=root;password=314159pI;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Catpersonal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("catpersonal");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cargo).HasMaxLength(80);
            entity.Property(e => e.Nombre).HasMaxLength(80);
        });

        modelBuilder.Entity<Catproducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("catproducto");

            entity.HasIndex(e => e.Descripcion, "UQ_CatProducto_Descripcion").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasMaxLength(40);
        });

        modelBuilder.Entity<Tblinventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tblinventario");

            entity.HasIndex(e => e.Idpersonal, "IX_tblInventario_IDPersonal");

            entity.HasIndex(e => e.Idproducto, "IX_tblInventario_IDProducto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cantidad).HasDefaultValueSql("'1'");
            entity.Property(e => e.FechaAlta)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Idpersonal).HasColumnName("IDPersonal");
            entity.Property(e => e.Idproducto).HasColumnName("IDProducto");
            entity.Property(e => e.TipoMovimiento).HasColumnType("enum('ENTRADA','SALIDA')");

            entity.HasOne(d => d.IdpersonalNavigation).WithMany(p => p.Tblinventarios)
                .HasForeignKey(d => d.Idpersonal)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_tblInventario_CatPersonal");

            entity.HasOne(d => d.IdproductoNavigation).WithMany(p => p.Tblinventarios)
                .HasForeignKey(d => d.Idproducto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_tblInventario_CatProducto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
