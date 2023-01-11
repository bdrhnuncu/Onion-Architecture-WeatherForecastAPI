using Microsoft.AspNetCore.Mvc;
using WeatherForecastApp.Application.Interface_s;

namespace WeatherForecastApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastControllers : ControllerBase
    {
        IGetWeatherForecast _getWeather;
        public WeatherForecastControllers(IGetWeatherForecast getWeather)
        {
            _getWeather = getWeather;
        }

        [HttpGet, Route("{city}")]
        public async Task<IActionResult> Get(string city)
        {
            return city == null || city == string.Empty ? NotFound() : Ok(_getWeather.Get(city));
        }

    }
}
