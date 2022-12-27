using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities.DbEntities
{
    public class Activity : BaseEntity
    {
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string? Venue { get; set; }
    }
}
