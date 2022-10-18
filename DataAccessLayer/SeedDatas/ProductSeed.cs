using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.SeedDatas;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product
            {
                Id = 1,
                Name = "Angular Speedster Board 2000",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 2,
                Name = "Green Angular Board 3000",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 15000,
                PictureUrl = "/images/products/sb-ang2.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 3,
                Name = "Core Board Speed Rush 3",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18000,
                PictureUrl = "/images/products/sb-core1.png",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 4,
                Name = "Net Core Super Board",
                Description =
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                Price = 30000,
                PictureUrl = "/images/products/sb-core2.png",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 5,
                Name = "React Board Super Whizzy Fast",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 25000,
                PictureUrl = "/images/products/sb-react1.png",
                Brand = "React",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 6,
                Name = "Typescript Entry Board",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 12000,
                PictureUrl = "/images/products/sb-ts1.png",
                Brand = "TypeScript",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 7,
                Name = "Core Blue Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1000,
                PictureUrl = "/images/products/hat-core1.png",
                Brand = "NetCore",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {Id = 8,
                Name = "Green React Woolen Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 8000,
                PictureUrl = "/images/products/hat-react1.png",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 9,
                Name = "Purple React Woolen Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1500,
                PictureUrl = "/images/products/hat-react2.png",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 10,
                Name = "Blue Code Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1800,
                PictureUrl = "/images/products/glove-code1.png",
                Brand = "VS Code",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 11,
                Name = "Green Code Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1500,
                PictureUrl = "/images/products/glove-code2.png",
                Brand = "VS Code",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 12,
                Name = "Purple React Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1600,
                PictureUrl = "/images/products/glove-react1.png",
                Brand = "React",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 13,
                Name = "Green React Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1400,
                PictureUrl = "/images/products/glove-react2.png",
                Brand = "React",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 14,
                Name = "Redis Red Boots",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 25000,
                PictureUrl = "/images/products/boot-redis1.png",
                Brand = "Redis",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 15,
                Name = "Core Red Boots",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 18999,
                PictureUrl = "/images/products/boot-core2.png",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 16,
                Name = "Core Purple Boots",
                Description =
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                Price = 19999,
                PictureUrl = "/images/products/boot-core1.png",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 17,
                Name = "Angular Purple Boots",
                Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                Price = 15000,
                PictureUrl = "/images/products/boot-ang2.png",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Id = 18,
                Name = "Angular Blue Boots",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18000,
                PictureUrl = "/images/products/boot-ang1.png",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            }
        );
    }
}