using CleanArchitectureWorkshop.Application.Contracts.Persistance;
using CleanArchitectureWorkshop.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Persistance
{
    public static class PersistanceServiceResgistration
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddDbContext<FirstRowTicketDbContext>(options => options.UseSqlServer());

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            return services;
        }
    }
}
