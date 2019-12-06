using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Services.Interfaces
{
    public interface IValuesService
    {
        List<Value> GetAll();
        Task<List<Value>> GetAllAsync();
    }
}