using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
  public class ProjetoModeloContext : DbContext
  {
    public DbSet<Cliente> Clientes { get; set; }

    public ProjetoModeloContext(DbContextOptions<ProjetoModeloContext> optionsBuilder) : base(optionsBuilder)
    {}

    #region Required
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<Cliente>()
         .HasIndex(p => p.ClientId);
       modelBuilder.Entity<Cliente>()
         .HasIndex(p => p.CPF);
    }
    #endregion

    public override int SaveChanges()
    {
      foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
      {
        if (entry.State == EntityState.Added)
        {
          entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        }

        if (entry.State == EntityState.Modified)
        {
          entry.Property("DataCadastro").IsModified = false;
        }
      }
      return base.SaveChanges();
    }
  }
}
