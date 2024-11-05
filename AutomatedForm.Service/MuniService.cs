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
    public class MuniService:ITblMuniService
    {
        private readonly ITblMuniRepository _muniRepository;
        public MuniService(ITblMuniRepository muniRepository)
        {
            _muniRepository = muniRepository;
        }
        public async Task<IEnumerable<TblMuni>> GetMunisAsync()
        {
            return await _muniRepository.GetMunisAsync();
        }
    }
}
