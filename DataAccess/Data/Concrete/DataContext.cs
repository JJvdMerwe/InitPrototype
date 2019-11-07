using InitPrototype.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace InitPrototype.DataAccess.Data.Concrete
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) 
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}