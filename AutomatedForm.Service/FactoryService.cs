using AutomatedForm.Core.Models;
using AutomatedForm.Core.Repositories;
using AutomatedForm.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Service
{
    public class FactoryService:ITblFactoryService
    {
        private readonly ITblFactoryRepository _factoryRepository;
        public FactoryService(ITblFactoryRepository factoryRepository)
        {
            _factoryRepository = factoryRepository;
        }
        public async Task<IEnumerable<TblFactory>> GetFactorysAsync()
        {
            return await _factoryRepository.GetFactorysAsync();
        }
    }
}
