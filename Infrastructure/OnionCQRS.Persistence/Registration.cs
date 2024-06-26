﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionCQRS.Application.Interfaces;
using OnionCQRS.Persistence.Context;
using OnionCQRS.Persistence.Repositories;

namespace OnionCQRS.Persistence;

public static class Registration
{
    public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
    }
}