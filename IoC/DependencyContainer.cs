using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Entities.Interfaces;
using Presenters;
using Repositories.EFCore.DataContext;
using Repositories.EFCore.Repositories;

namespace IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MusicfyContext>(options => options.UseSqlServer(configuration.GetConnectionString("MusicfyDB")));
           
            return services;
        }
    }
}
