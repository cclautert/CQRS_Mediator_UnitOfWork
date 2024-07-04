using CQRS_Mediator_UnitOfWork.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Mediator_UnitOfWork.Data
{
    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; } = null!; // <--->

        public DbSet<Order> Orders { get; set; } = null!; // <-->
    }
}
