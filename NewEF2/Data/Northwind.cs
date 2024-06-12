namespace NewEF2.Data;
using Microsoft.EntityFrameworkCore;
using NewEF2.Models;


public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ./Northwind.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) //menentukan struktur dari db
    {
        modelBuilder.Entity<Category>(cat =>
        {
            cat.HasMany<Product>(c => c.Products).WithOne(p => p.Category).OnDelete(DeleteBehavior.Cascade);
        });
    }
}
