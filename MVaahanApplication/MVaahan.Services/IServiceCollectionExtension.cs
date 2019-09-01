using Microsoft.Extensions.DependencyInjection;
using MVaahan.ServiceContracts.Admin;
using MVaahan.Services.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVaahan.Services
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(ILoginService), typeof(LoginService));
            return services;
        }
    }
}
