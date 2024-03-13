using Domain.DB;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class DependecyInjection
    {
        //Injection del DB Context
        public static IServiceCollection AddCustomizedDataStore(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApiNet6Context>(
                options => options.UseMySql(Configuration.GetConnectionString("Conn_mysql"),
                ServerVersion.AutoDetect(Configuration.GetConnectionString("Conn_mysql")),
                null));
            return services;
        }

        //Injection del Repositorio
        public static IServiceCollection AddCustomizedRepository(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
