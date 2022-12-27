using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities
{
    public class Result
    {
        public string Date { get; set; }
        public string Day { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Degree { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Night { get; set; }
        public string Humidity { get; set; }
    }
}
