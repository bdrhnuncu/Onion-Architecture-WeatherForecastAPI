using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Application.Interface_s.Repositories.GenericRepository
{
    public interface IBaseQueryRepository<T>
    {
        Task<List<T>> GetAll();
    }
}
