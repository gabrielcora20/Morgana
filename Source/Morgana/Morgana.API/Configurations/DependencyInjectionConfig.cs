using Microsoft.Extensions.DependencyInjection;
using Morgana.Infra.CrossCutting.IoC;
using System;

namespace Morgana.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
