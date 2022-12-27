using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Application.Interface_s.Repositories.GenericRepository
{
    public interface IBaseCommandRepository<T>
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
