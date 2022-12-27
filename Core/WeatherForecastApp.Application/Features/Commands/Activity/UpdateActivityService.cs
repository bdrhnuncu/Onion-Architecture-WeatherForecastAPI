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
    public class UpdateActivityService : IRequestHandler<UpdateActivityRequest, UpdateActivityResponse>
    {
        IActivityCommandRepository _commandRepository;
        IMapper _mapper;
        public UpdateActivityService(IActivityCommandRepository commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public async Task<UpdateActivityResponse> Handle(UpdateActivityRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var map = _mapper.Map<Domain.Entities.DbEntities.Activity>(request);
                await _commandRepository.Update(map);
                return new UpdateActivityResponse() { Message = "Successfully" };
            }
            catch (Exception ex)
            {
                return new UpdateActivityResponse() { Message = ex.Message };
            }
        }
    }

    public class UpdateActivityRequest : IRequest<UpdateActivityResponse>
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string? Venue { get; set; }
    }

    public class UpdateActivityResponse
    {
        public string Message { get; set; }
    }
}
