using CQRS_Mediator_UnitOfWork.Domain.Commands.Requests;
using CQRS_Mediator_UnitOfWork.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_UnitOfWork.Controllers;

[ApiController]
[Route("v1/customers")]
public class CustomerController : ControllerBase
{
    // POST
    [HttpPost]
    [Route("")]
    public Task<CreateCustomerResponse> Create(IMediator mediator, CreateCustomerRequest command)
    {
        return mediator.Send(command);
    }

    // PUT
    public IActionResult Update()
    {
        return null;
    }   

    // DELETE
    public IActionResult Delete()
    {
        return null;
    }

    // GET
    public IActionResult Index()
    {
        return null;
    }
}