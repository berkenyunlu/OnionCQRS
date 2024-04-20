using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionCQRS.Domain.Entities;

namespace OnionCQRS.Persistence.Configurations;

public class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(256);

        builder.HasData(
        new Category()
        {
            Id = 1,
            Name = "Elektrik",
            Priorty = 1,
            ParentId = 0
        },
        new Category()
        {
            Id = 2,
            Name = "Moda",
            Priorty = 2,
            ParentId = 0
        },
        new Category()
        {
            Id = 3,
            Name = "Bilgisayar",
            Priorty = 1,
            ParentId = 1
        },
        new Category()
        {
            Id = 4,
            Name = "Kadın",
            Priorty = 1,
            ParentId = 2
        }
        );
    }
}