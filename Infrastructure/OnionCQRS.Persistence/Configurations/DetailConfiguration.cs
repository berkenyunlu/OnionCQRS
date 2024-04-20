using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionCQRS.Domain.Entities;

namespace OnionCQRS.Persistence.Configurations;

public class DetailConfiguration : IEntityTypeConfiguration<Detail>
{
    public void Configure(EntityTypeBuilder<Detail> builder)
    {
        builder.Property(x => x.Description).HasMaxLength(256);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(256);
        Faker faker = new("tr");

        Detail detail3 = new()
        {
            Id = 3,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 4,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };

        builder.HasData(new Detail()
        {
            Id = 1,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 1,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        }, 
        new()
        {
            Id = 2,
            Title = faker.Lorem.Sentence(2),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 3,
            CreatedDate = DateTime.Now,
            IsDeleted = true,
        }, 
        new()
        {
            Id = 3,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 4,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        });
    }
}