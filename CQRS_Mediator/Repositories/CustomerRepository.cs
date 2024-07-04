using CQRS_Mediator_UnitOfWork.Data;
using CQRS_Mediator_UnitOfWork.Models;

namespace CQRS_Mediator_UnitOfWork.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
            //Was used Before UnitOfWork
            //_context.SaveChanges();
        }
    }
}
