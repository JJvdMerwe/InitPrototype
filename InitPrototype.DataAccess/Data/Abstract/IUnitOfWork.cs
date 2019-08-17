using System;
using InitPrototype.DataAccess.Models;

namespace InitPrototype.DataAccess.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
         IGenericRepository<Competition> CompetitionRepository { get; }
    }
}