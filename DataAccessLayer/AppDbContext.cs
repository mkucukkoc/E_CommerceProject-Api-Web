using Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace DataAccessLayer;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//bu satırda tüm configurationları çalıştırıyoruz.
        base.OnModelCreating(modelBuilder);
    }
}