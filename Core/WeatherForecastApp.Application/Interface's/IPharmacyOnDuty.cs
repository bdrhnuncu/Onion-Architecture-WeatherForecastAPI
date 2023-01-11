using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Domain.Entities;

namespace WeatherForecastApp.Application.Interface_s
{
    public interface IPharmacyOnDuty
    {
        PharmacuOnDutyResponse Get(PharmacyOnDutyRequest pharmacyOnDuty);
    }
}
