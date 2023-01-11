using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Domain.Entities
{
    public class PharmacuOnDutyResponse
    {
        public bool Success { get; set; }
        public List<PharmacyOnDutyResponseResult> Result { get; set; }
    }
}
