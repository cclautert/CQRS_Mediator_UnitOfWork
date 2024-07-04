using CQRS_Mediator_UnitOfWork.Data;
using CQRS_Mediator_UnitOfWork.Models;
using CQRS_Mediator_UnitOfWork.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_UnitOfWork.Controllers;

[ApiController]
[Route("v1/orders")]

public class OrderController : ControllerBase
{
    [HttpPost]
    [Route("")]
    public Order Post(ICustomerRepository customerRepository, IOrderRepository orderRepository, IUnitOfWork unitOfWork)
    {
        try
        {
            var customer = new Customer {Name = "Cristiano"};
            var order = new Order {Number = "123", Customer = customer};

            customerRepository.Save(customer);
            orderRepository.Save(order);

            unitOfWork.Commit();

            return order;
        }
        catch (Exception e)
        {
            unitOfWork.Rollback();
            Console.WriteLine(e);
            throw;
        }
    }
}