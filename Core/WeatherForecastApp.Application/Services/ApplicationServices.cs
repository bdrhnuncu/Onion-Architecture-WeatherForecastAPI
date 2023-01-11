using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Mapping;

namespace WeatherForecastApp.Application.Services
{
    public class ApplicationServices : IService
    {
        public void AddApplicationServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());

        }

        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
