using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionCQRS.Persistence.Context;

namespace OnionCQRS.Persistence;

public static class Registration
{
    public static void AddPersistence(this IServiceCollection service,IConfiguration configuration)
    {
        service.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}