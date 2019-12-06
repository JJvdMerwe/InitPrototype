using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DataContext _dataContext;
        private DbSet<T> _dbSet;

        public IQueryable<T> DataTable => _dataContext.Set<T>();

        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(T newEntity)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(T newEntity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            List<T> values = await DataTable.ToListAsync();

            return values;
        }
    }
}