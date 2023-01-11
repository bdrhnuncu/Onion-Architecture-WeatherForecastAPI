using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities
{
    public class IMDBResponse
    {
        public bool Success { get; set; }
        public List<IMDBResponseResult> Result { get; set; }
    }
}
