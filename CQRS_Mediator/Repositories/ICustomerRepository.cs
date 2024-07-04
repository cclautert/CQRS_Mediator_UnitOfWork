using CQRS_Mediator_UnitOfWork.Models;

namespace CQRS_Mediator_UnitOfWork.Repositories;

public interface ICustomerRepository
{
    void Save(Customer customer);   
}