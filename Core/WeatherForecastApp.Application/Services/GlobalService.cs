using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Application.Services
{
    public static class GlobalService
    {
        public static void AddAllServices(this IServiceCollection serviceCollection, params IService[] services)
        {
            foreach (var service in services)
            {
                service.Load(serviceCollection);
            }

            
        }
    }
}
