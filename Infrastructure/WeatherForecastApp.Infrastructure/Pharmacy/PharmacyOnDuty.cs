using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Interface_s;
using WeatherForecastApp.Domain.Entities;

namespace WeatherForecastApp.Infrastructure.Pharmacy
{
    public class PharmacyOnDuty : IPharmacyOnDuty
    {
        public PharmacuOnDutyResponse Get(PharmacyOnDutyRequest pharmacyOnDuty)
        {
            var client = new RestClient($"https://api.collectapi.com/health/dutyPharmacy?ilce={pharmacyOnDuty.District}&il={pharmacyOnDuty.City}");
            var request = new RestRequest("",Method.Get);
            request.AddHeader("authorization", "apikey 0hewRhTvkOgWxqKzh8fJ7D:5MvMVglYwEtlinrDsVCTcq");
            request.AddHeader("content-type", "application/json");
            RestResponse response = client.Execute(request);
            var convert = JsonConvert.DeserializeObject<JToken>(response.Content);
            return convert.ToObject<PharmacuOnDutyResponse>();
        }
    }
}
