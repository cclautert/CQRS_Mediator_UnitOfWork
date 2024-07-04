namespace CQRS_Mediator_UnitOfWork.Data
{
    public interface IUnitOfWork
    {
        Task Rollback();
        void Commit();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public Task Rollback()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
