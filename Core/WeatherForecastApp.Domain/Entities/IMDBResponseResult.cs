using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities
{
    public class IMDBResponseResult
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string IMDBId { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
    }
}
