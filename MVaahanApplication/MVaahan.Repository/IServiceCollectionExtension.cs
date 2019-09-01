using Microsoft.Extensions.DependencyInjection;
using MVaahan.Repository.Admin;
using MVaahan.RepositoryContracts.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVaahan.Repository
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositoryDependency(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<MVaahanDataContext>(s => new MVaahanDataContext(connectionString));
            services.AddScoped(typeof(ILoginRepository), typeof(LoginRepository));
            return services;
        }
    }

    //Scaffold-DbContext "Server=NIT-LPT-R101\\SQLEXPRESS;Database=MobileMediClaim;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model
}
//Scaffold-DbContext "Server=localhost;Database=testdatabase1;user=appuser;password=Akshay@123456" Pomelo.EntityFrameworkCore.MySql -OutputDir Model
