using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyExpenses
{
    using FamilyExpenses.Models;
    // FamilyExpensesDbContext.cs
    using Microsoft.EntityFrameworkCore;

    public class FamilyExpensesDbContext : DbContext
    {

        public FamilyExpensesDbContext(DbContextOptions<FamilyExpensesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=familyexpenses;Username=postgres;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales del modelo
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(u => u.Email).IsRequired();
                entity.HasIndex(u => u.Email).IsUnique();
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.Property(g => g.Monto).HasColumnType("decimal(18,2)");
                entity.HasIndex(g => g.Fecha);
            });
        }
    }
}
