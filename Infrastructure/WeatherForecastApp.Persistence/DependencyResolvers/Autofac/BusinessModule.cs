using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using WeatherForecastApp.Application.Interface_s;
using WeatherForecastApp.Application.Interface_s.Repositories.ActivityRepository;
using WeatherForecastApp.Infrastructure.WeatherForecast;
using WeatherForecastApp.Persistence.Repositories.ActivityRepository;

namespace WeatherForecastApp.Persistence.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ActivityCommandRepository>().As<IActivityCommandRepository>();
            builder.RegisterType<ActivityQueryRepository>().As<IActivityQueryRepository>();
            builder.RegisterType<GetWeatherForecast>().As<IGetWeatherForecast>();
        }
    }
}
