using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities
{
    public class PharmacyOnDutyRequest
    {
        public string City { get; set; }
        public string? District { get; set; }
    }
}
