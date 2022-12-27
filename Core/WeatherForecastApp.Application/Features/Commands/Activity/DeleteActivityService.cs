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
    public class DeleteActivityService : IRequestHandler<DeleteActivityRequest, DeleteActivityResponse>
    {
        IActivityCommandRepository _commandRepository;
        IMapper _mapper;
        public DeleteActivityService(IActivityCommandRepository commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public async Task<DeleteActivityResponse> Handle(DeleteActivityRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var map = _mapper.Map<Domain.Entities.DbEntities.Activity>(request);
                await _commandRepository.Delete(map);
                return new DeleteActivityResponse() { Message = "Successfully" };
            }
            catch (Exception ex)
            {

                return new DeleteActivityResponse() { Message = ex.Message };
            }
        }
    }

    public class DeleteActivityRequest : IRequest<DeleteActivityResponse>
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string? Venue { get; set; }
    }

    public class DeleteActivityResponse
    {
        public string Message { get; set; }
    }
}
