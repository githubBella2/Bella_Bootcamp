// using Microsoft.EntityFrameworkCore;

using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
namespace EntityFramework;

class Northwind : DbContext
{
    // menambahkan tabel di database 
    //tabel kategori, produk, maka dibkin file sendiri

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    // configuring DB
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlite("Data Source=Northwind.db");
        // must install :
        // Npgsql.EntityFrameworkCore.PostgreSql
        // PostgreSql
        // optionsBuilder.Npgsql("Host=localhost;Port=5432;Database=myDB;Username=postgre;Password=postgre");
    }



}
