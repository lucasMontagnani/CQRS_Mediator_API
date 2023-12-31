using Domain.Commands.Requests;
using Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_API.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromServices] IMediator mediator, [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}
