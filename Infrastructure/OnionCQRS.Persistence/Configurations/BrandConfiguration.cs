using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionCQRS.Domain.Entities;

namespace OnionCQRS.Persistence.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(256);
        Faker faker = new Faker("tr");


        builder.HasData(
        new Brand()
        {
            Id = 1,
            Name = faker.Commerce.Department(),
        },
        new Brand()
        {
            Id = 2,
            Name = faker.Commerce.Department(),
        },
        new Brand()
        {
            Id = 3,
            Name = faker.Commerce.Department(),
            IsDeleted = true
        }
        );
    }
}