using Ispi.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ispi.API.Data;

public class AppDbContext : DbContext
{
    public DbSet<ShoppingItem> ShoppingItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=JANKOTUF;Database=Ispit.API_Db;Trusted_Connection=True;TrustServerCertificate=True;");

        base.OnConfiguring(optionsBuilder);
    }
}
