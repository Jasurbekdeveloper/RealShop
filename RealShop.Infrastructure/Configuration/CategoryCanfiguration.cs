using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealShop.Domain.Entities;

namespace RealShop.Infrastructure.Configuration;

public class CategoryCanfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category))
            .HasKey(a => a.Id);

        builder.Property(a => a.Name)
            .IsRequired().
            HasMaxLength(50);

        builder.Property(a => a.CreatedDate)
            .IsRequired();

    }
}
