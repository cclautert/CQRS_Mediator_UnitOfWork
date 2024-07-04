using CQRS_Mediator_UnitOfWork.Domain.Commands.Responses;
using MediatR;

namespace CQRS_Mediator_UnitOfWork.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }

        public string Email { get; set; }   
    }
}
