using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data.Abstract;
using DataAccess.Models;
using Services.Interfaces;

namespace Services.Implementations
{
    public class ValuesService : IValuesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ValuesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Value> GetAll()
        {
            return _unitOfWork.ValueRepository.DataTable.ToList();
        }

        public async Task<List<Value>> GetAllAsync()
        {
            return await _unitOfWork.ValueRepository.GetAllAsync();
        }
    }
}