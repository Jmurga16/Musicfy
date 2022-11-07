
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Entities.Interfaces;

using Repositories.EFCore.DataContext;
using Repositories.EFCore.Repositories;
using UseCasesPorts.ListAlbum;
using UseCases.ListAlbum;
using Presenters.ListAlbum;
using UseCases.FormAlbum;
using UseCasesPorts.FormAlbum;
using Presenters.FormAlbum;
using UseCases.Common.Validators;
using FluentValidation;

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

            services.AddValidatorsFromAssembly(typeof(CreateAlbumValidator).Assembly);

            services.AddScoped<ICreateAlbumInputPort, CreateAlbumInteractor>();
            services.AddScoped<ICreateAlbumOutputPort, CreateAlbumPresenter>();

            services.AddScoped<IUpdateAlbumInputPort, UpdateAlbumInteractor>();
            services.AddScoped<IUpdateAlbumOutputPort, UpdateAlbumPresenter>();

            services.AddScoped<IDeleteAlbumInputPort, DeleteAlbumInteractor>();
            services.AddScoped<IDeleteAlbumOutputPort, DeleteAlbumPresenter>();

            return services;
        }
    }
}
