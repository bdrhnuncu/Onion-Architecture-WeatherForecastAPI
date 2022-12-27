using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Interface_s.Repositories.GenericRepository;
using WeatherForecastApp.Domain.Entities.DbEntities;

namespace WeatherForecastApp.Application.Interface_s.Repositories.ActivityRepository
{
    public interface IActivityCommandRepository : IBaseCommandRepository<Activity>
    {

    }
}
