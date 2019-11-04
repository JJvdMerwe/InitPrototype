using System.Threading.Tasks;
using InitPrototype.DataAccess.Data.Abstract;
using InitPrototype.DataAccess.Models;

namespace InitPrototype.DataAccess.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Contest> ContestRepository => throw new System.NotImplementedException();

        public IGenericRepository<ContestantAccount> ContestantAccountRepository => throw new System.NotImplementedException();

        public IGenericRepository<Entry> EntryRepository => throw new System.NotImplementedException();

        public IGenericRepository<Phase> PhaseRepository => throw new System.NotImplementedException();

        public IGenericRepository<Provider> ProviderRepository => throw new System.NotImplementedException();

        public IGenericRepository<User> UserRepository => throw new System.NotImplementedException();

        public IGenericRepository<UserType> UserTypeRepository => throw new System.NotImplementedException();

        public IGenericRepository<Value> ValueRepository => throw new System.NotImplementedException();

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