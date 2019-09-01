using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVaahan.Repository
{
    public class Program
    {
        static void Main(string[] args) {
            var services = new ServiceCollection();
            services.AddRepositoryDependency(args[0]);
        }
    }
}
