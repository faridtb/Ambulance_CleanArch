using Application.Features.Queries.GetAllRegistrations;
using Application.Interfaces.Repository;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ambulance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IMediator mediator;
        public ApiController(IMediator mediator)
        {
            this.mediator = mediator;
                
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllRegistrationsQuery();
            var response = await mediator.Send(query);

            return Ok(response);
        }
    }
}
