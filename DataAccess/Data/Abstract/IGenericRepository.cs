using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InitPrototype.DataAccess.Data.Abstract
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IQueryable<T> DataTable { get; }
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match);
        void Create(T newEntity);
        Task CreateAsync(T newEntity);
        void Update(T entity);
        void Delete(T entity);
    }
}