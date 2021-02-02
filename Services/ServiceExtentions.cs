using Microsoft.Extensions.DependencyInjection;
using MVCApp.Services.Implementations;
using MVCApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.Services
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IJournalService, JournalService>();
            return services;
        }
    }
}
