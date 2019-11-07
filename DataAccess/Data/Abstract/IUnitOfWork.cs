using System;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<Contest> ContestRepository { get; }
        IGenericRepository<ContestantAccount> ContestantAccountRepository { get; }
        IGenericRepository<Entry> EntryRepository { get; }
        IGenericRepository<Phase> PhaseRepository { get; }
        IGenericRepository<Provider> ProviderRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<UserType> UserTypeRepository { get; }
        IGenericRepository<Value> ValueRepository { get; }

        void Commit();

        Task CommitAsync();
         
    }
}