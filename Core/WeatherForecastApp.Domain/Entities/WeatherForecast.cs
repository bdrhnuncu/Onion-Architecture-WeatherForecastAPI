using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities
{
    public class WeatherForecast
    {
        public bool Success { get; set; }
        public string City { get; set; }
        public List<Result> Result { get; set; }
    }
}
