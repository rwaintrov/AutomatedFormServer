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
    public class LaboratoryService: ITblLaboratoryService
    {
        private readonly ITblLaboratoryRepository _LaboratoryRepository;
        public LaboratoryService(ITblLaboratoryRepository LaboratoryRepository)
        {
            _LaboratoryRepository = LaboratoryRepository;
        }
        public async Task<IEnumerable<TblLaboratory>> GetLaboratoriesAsync()
        {
            return await _LaboratoryRepository.GetLaboratoriesAsync();
        }
    }
}
