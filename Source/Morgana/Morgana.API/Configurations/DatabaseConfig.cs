﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Morgana.API.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            //if (services == null) throw new ArgumentNullException(nameof(services));

            //services.AddDbContext<EquinoxContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<EventStoreSqlContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}