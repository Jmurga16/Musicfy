using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Entities.Interfaces;
using Presenters;
using Repositories.EFCore.DataContext;
using Repositories.EFCore.Repositories;
using UseCasesPorts.ListAlbum;
using UseCases.ListAlbum;
using Presenters.ListAlbum;

namespace IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMusicfyServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MusicfyContext>(options => options.UseSqlServer(configuration.GetConnectionString("connectionString")));


            services.AddScoped<IAlbumRepository, AlbumRepository>();        
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IListAlbumInputPort, ListAlbumInteractor>();
            services.AddScoped<IListAlbumOutputPort, ListAlbumPresenter>();

            return services;
        }
    }
}
