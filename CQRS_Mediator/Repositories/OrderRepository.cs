using CQRS_Mediator_UnitOfWork.Data;
using CQRS_Mediator_UnitOfWork.Models;

namespace CQRS_Mediator_UnitOfWork.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public void Save(Order order)
        {
            _context.Orders.Add(order);
            //Was used Before UnitOfWork
            //_context.SaveChanges();
        }
    }
}
