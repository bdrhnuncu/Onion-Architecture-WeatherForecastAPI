using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Interface_s.Repositories.GenericRepository;
using WeatherForecastApp.Domain;
using WeatherForecastApp.Persistence.Contexts;

namespace WeatherForecastApp.Persistence.Repositories.GenericRepository
{
    public class BaseQueryRepository<T, Context> : IBaseQueryRepository<T> 
        where T : BaseEntity,new()
        where Context : PostgreSqlDbContext, new()
    {
        public async Task<List<T>> GetAll()
        {
            using (Context cntx = new Context())
            {
                var getAll = await cntx.Set<T>().ToListAsync();
                return getAll;
            }
        }
    }
}
