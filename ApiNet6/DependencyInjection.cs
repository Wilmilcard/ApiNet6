using ApiNet6.Interfaces;
using ApiNet6.Services;

namespace ApiNet6
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomizedServicesProject(this IServiceCollection services)
        {
            services.AddScoped<IAlquilerServices, AlquilerServices>();

            return services;
        }
    }
}
