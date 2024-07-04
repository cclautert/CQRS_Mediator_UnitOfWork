using CQRS_Mediator_UnitOfWork.Models;

namespace CQRS_Mediator_UnitOfWork.Repositories;

public interface IOrderRepository
{
    void Save(Order order);
}