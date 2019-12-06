using System;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Value> ValueRepository { get; }

        void Commit();

        Task CommitAsync();
         
    }
}