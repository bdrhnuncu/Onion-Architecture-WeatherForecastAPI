using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using WeatherForecastApp.Application.Features.Commands.Activity;
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
            if (city == string.Empty || city == null) return BadRequest();
            var get = _getWeather.Get(city);
            return Ok(get);
        }

    }
}
