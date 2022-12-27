using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Domain.Entities.DbEntities;

namespace WeatherForecastApp.Persistence.Contexts
{
    public class PostgreSqlDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=1234;Database=WeatherForecastApplication");
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
