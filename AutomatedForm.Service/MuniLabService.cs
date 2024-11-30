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
    public class MuniLabService: ITransMuniLabService
    {
        private readonly ITransMuniLabRepository _muniLabRepository;
        public MuniLabService(ITransMuniLabRepository muniLabRepository)
        {
            _muniLabRepository = muniLabRepository;
        }
        public async Task<IEnumerable<TransMuniLab>> GetMuniLabAsync()
        {
            return await _muniLabRepository.GetMuniLabsAsync();
        }

        public async Task<TblLaboratory> GetLabByMuniIdAsync(int id)
        {
            return await _muniLabRepository.GetLabByMuniIdAsync(id);
        }
    }
}
