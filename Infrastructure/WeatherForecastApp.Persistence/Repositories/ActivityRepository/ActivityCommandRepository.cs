using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Interface_s.Repositories.ActivityRepository;
using WeatherForecastApp.Domain.Entities.DbEntities;
using WeatherForecastApp.Persistence.Contexts;
using WeatherForecastApp.Persistence.Repositories.GenericRepository;

namespace WeatherForecastApp.Persistence.Repositories.ActivityRepository
{
    public class ActivityCommandRepository : BaseCommandRepository<Activity, PostgreSqlDbContext>, IActivityCommandRepository
    {

    }
}
