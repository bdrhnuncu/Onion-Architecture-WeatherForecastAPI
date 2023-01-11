using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Features.Commands.Activity;
using WeatherForecastApp.Application.Features.Queries.Activity;
using WeatherForecastApp.Domain.Entities.DbEntities;

namespace WeatherForecastApp.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Activity, GetAllActivityResponse>().ReverseMap();
            CreateMap<Activity, CreateActivityRequest>().ReverseMap();
            CreateMap<Activity, DeleteActivityRequest>().ReverseMap();
            CreateMap<Activity, UpdateActivityRequest>().ReverseMap();
        }
    }
}
