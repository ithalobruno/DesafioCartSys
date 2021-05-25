using DesafioCartSys.Business.Interfaces;
using DesafioCartSys.Business.Notifications;
using DesafioCartSys.Business.Services;
using DesafioCartSys.Data.Context;
using DesafioCartSys.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioCartSys.API.Configurations
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {

            services.AddScoped<MeuDbContextApi>();
            services.AddScoped<IClienteRepositorioApi, ClienteRepositorioApi>();
          
            services.AddScoped<INotificadorApi, NotificadorApi>();
            services.AddScoped<IClienteServiceApi, ClienteServiceApi>();
          
            return services;
        }
    }
}
