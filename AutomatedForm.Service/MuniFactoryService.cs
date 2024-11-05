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
    public class MuniFactoryService:ITransMuniFactoryService
    {
        private readonly ITransMuniFactoryRepository _muniFactoryRepository;
        public MuniFactoryService(ITransMuniFactoryRepository muniFactoryRepository)
        {
            _muniFactoryRepository = muniFactoryRepository;
        }
        public async Task<IEnumerable<TransMuniFactory>> GetMuniFactorysAsync()
        {
            return await _muniFactoryRepository.GetMuniFactorysAsync();
        }
    }
}
