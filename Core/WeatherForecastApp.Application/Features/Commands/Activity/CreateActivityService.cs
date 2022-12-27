using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Application.Interface_s.Repositories.ActivityRepository;

namespace WeatherForecastApp.Application.Features.Commands.Activity
{
    public class CreateActivityService : IRequestHandler<CreateActivityRequest, CreateActivityResponse>
    {
        IActivityCommandRepository _commandRepository;
        IMapper _mapper;
        public CreateActivityService(IActivityCommandRepository commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public async Task<CreateActivityResponse> Handle(CreateActivityRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var map = _mapper.Map<Domain.Entities.DbEntities.Activity>(request);
                await _commandRepository.Create(map);
                return new CreateActivityResponse() { Message = "Succesfully" };
            }
            catch (Exception ex)
            {
                return new CreateActivityResponse() { Message = ex.Message };
            }
        }
    }

    public class CreateActivityRequest : IRequest<CreateActivityResponse>
    {
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string? Venue { get; set; }
    }

    public class CreateActivityResponse
    {
        public string Message { get; set; }
    }
}
