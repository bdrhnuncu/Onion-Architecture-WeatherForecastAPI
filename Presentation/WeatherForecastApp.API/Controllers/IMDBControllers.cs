using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastApp.Application.Interface_s;
using WeatherForecastApp.Domain.Entities;

namespace WeatherForecastApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMDBControllers : ControllerBase
    {
        IIMDB _imdb;
        public IMDBControllers(IIMDB imdb)
        {
            _imdb = imdb;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] IMDBRequest imdbRequest)
        {
            return imdbRequest == null ? BadRequest() : Ok(_imdb.Get(imdbRequest));
        }

    }
}
