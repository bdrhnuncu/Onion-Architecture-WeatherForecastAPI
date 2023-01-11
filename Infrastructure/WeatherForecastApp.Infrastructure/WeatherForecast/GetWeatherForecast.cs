using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Interface_s;

namespace WeatherForecastApp.Infrastructure.WeatherForecast
{
    public class GetWeatherForecast : IGetWeatherForecast
    {
        public Domain.Entities.WeatherForecastResponse Get(string city)
        {
            var client = new RestClient($"https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city={city}");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("authorization", "apikey 0hewRhTvkOgWxqKzh8fJ7D:5MvMVglYwEtlinrDsVCTcq");
            request.AddHeader("content-type", "application/json");
            RestResponse response = client.Execute(request); 
            var convertToClass = JsonConvert.DeserializeObject<JToken>(response.Content);
            return convertToClass.ToObject<Domain.Entities.WeatherForecastResponse>();
        }
       
    }
}
