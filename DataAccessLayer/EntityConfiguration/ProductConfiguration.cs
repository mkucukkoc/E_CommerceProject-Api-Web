using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities;

namespace DataAccessLayer.EntityConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.Price).IsRequired();
        builder.Property(x => x.Brand).IsRequired();
        builder.Property(x => x.Type).IsRequired();
        builder.Property(x => x.PictureUrl).IsRequired();
        builder.Property(x => x.QuantityInStock).IsRequired();
        
    }
}