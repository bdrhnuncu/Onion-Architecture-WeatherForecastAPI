using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastApp.Application.Interface_s;
using WeatherForecastApp.Domain.Entities;

namespace WeatherForecastApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyControllers : ControllerBase
    {
        IPharmacyOnDuty _pharmacyOnDuty;
        public PharmacyControllers(IPharmacyOnDuty pharmacyOnDuty)
        {
            _pharmacyOnDuty = pharmacyOnDuty;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PharmacyOnDutyRequest pharmacyOnDutyRequest)
        {
            return pharmacyOnDutyRequest == null ? BadRequest() : Ok(_pharmacyOnDuty.Get(pharmacyOnDutyRequest));
        }
    }
}
