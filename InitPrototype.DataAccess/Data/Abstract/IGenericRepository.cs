using System;
using System.Linq;

namespace InitPrototype.DataAccess.Data.Abstract
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IQueryable<T> DataTable { get; }
    }
}