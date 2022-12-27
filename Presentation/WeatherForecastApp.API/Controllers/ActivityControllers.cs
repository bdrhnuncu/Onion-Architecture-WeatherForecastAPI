using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastApp.Application.Features.Commands.Activity;
using WeatherForecastApp.Application.Features.Queries.Activity;

namespace WeatherForecastApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityControllers : ControllerBase
    {
        IMediator _mediator;
        public ActivityControllers(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateActivityRequest updateActivityRequest)
        {
            if (updateActivityRequest == null) return BadRequest();
            var update = await _mediator.Send(updateActivityRequest);
            return Ok(update);
        }

        [HttpGet, Route("[Action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllActivityRequest getAllActivityRequest)
        {
            if (getAllActivityRequest == null) return NotFound();
            var getAll = await _mediator.Send(getAllActivityRequest);
            return Ok(getAll);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateActivityRequest createActivityRequest)
        {
            if (createActivityRequest == null) return BadRequest();
            var create = await _mediator.Send(createActivityRequest);
            return Ok(create);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteActivityRequest deleteActivityRequest)
        {
            if (deleteActivityRequest == null) return BadRequest();
            var delete = await _mediator.Send(deleteActivityRequest);
            return Ok(delete);
        }
    }
}
