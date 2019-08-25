using System;
using System.Threading.Tasks;
using InitPrototype.DataAccess.Models;

namespace InitPrototype.DataAccess.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<Contest> ContestRepository { get; }
        IGenericRepository<ContestantAccount> ContestantAccountRepository { get; }
        IGenericRepository<Phase> PhaseRepository { get; }
        IGenericRepository<Provider> ProviderRepository { get; }
        IGenericRepository<Entry> EntryRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<UserType> UserTypeRepository { get; }

        void Commit();

        Task CommitAsync();
         
    }
}