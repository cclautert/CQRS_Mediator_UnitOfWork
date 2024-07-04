using CQRS_Mediator_UnitOfWork.Domain.Commands.Requests;
using CQRS_Mediator_UnitOfWork.Domain.Commands.Responses;
using MediatR;

namespace CQRS_Mediator_UnitOfWork.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = Guid.Empty,
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
