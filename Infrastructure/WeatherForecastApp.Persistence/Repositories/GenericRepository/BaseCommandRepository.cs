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
    public class BaseCommandRepository<T, Context> : IBaseCommandRepository<T>
        where T : BaseEntity,new()
        where Context : PostgreSqlDbContext, new()
    {
        public async Task Create(T entity)
        {
            using (Context cntx = new Context())
            {
                var add = cntx.Add(entity); 
                add.State = EntityState.Added;
                await cntx.SaveChangesAsync();
            }
        }

        public async Task Delete(T entity)
        {
            using (Context cntx = new Context())
            {
                var delete = cntx.Entry(entity);
                delete.State = EntityState.Deleted; 
                await cntx.SaveChangesAsync();
            }
        }

        public async Task Update(T entity)
        {
            using (Context cntx = new Context())
            {
                var update = cntx.Entry(entity);
                update.State = EntityState.Modified;
                await cntx.SaveChangesAsync();
            }
        }
    }
}
