using System.Threading.Tasks;
using DataAccess.Data.Abstract;
using DataAccess.Models;

namespace DataAccess.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public IGenericRepository<Value> ValueRepository => new GenericRepository<Value>(_dataContext);

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}