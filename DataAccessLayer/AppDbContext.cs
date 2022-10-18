using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
}