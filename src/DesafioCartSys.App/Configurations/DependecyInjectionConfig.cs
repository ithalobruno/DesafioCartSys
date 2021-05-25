using DesafioCartSys.App.Extensions;
using DesafioCartSys.Business.Interfaces;
using DesafioCartSys.Business.Notifications;
using DesafioCartSys.Business.Services;
using DesafioCartSys.Data.Context;
using DesafioCartSys.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioCartSys.App.Configurations
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {

            services.AddScoped<MeuDbContext>();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
          
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IClienteService, ClienteService>();
          
            return services;
        }
    }
}
