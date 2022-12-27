using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Interface_s.Repositories.ActivityRepository;

namespace WeatherForecastApp.Application.Features.Queries.Activity
{
    public class GetAllActivityService : IRequestHandler<GetAllActivityRequest, List<GetAllActivityResponse>>
    {
        IActivityQueryRepository _activityQuery;
        IMapper _mapper;
        public GetAllActivityService(IActivityQueryRepository activityQuery, IMapper mapper)
        {
            _activityQuery = activityQuery;
            _mapper = mapper;
        }

        public async Task<List<GetAllActivityResponse>> Handle(GetAllActivityRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var getAll = await _activityQuery.GetAll();
                var map = _mapper.Map<List<GetAllActivityResponse>>(getAll);
                return map;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class GetAllActivityRequest : IRequest<List<GetAllActivityResponse>>
    {
    }

    public class GetAllActivityResponse
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string? Venue { get; set; }
    }
}
