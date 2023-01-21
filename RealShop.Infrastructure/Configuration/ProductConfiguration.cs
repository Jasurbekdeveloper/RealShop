using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RealShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealShop.Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(name: nameof(Product))
                .HasKey(product => product.Id);

            builder.Property(product => product.Name)
                .IsRequired().HasMaxLength(50);

            builder.Property(product => product.Price)
                .IsRequired();

            builder.Property(product => product.CategoryId)
                .IsRequired();

            builder.HasOne(product => product.ProductCategory)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
