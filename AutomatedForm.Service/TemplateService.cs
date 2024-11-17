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
    public class TemplateService:ITblTemplateService
    {
        private readonly ITblTemplateRepository _templateRepository;
        public TemplateService(ITblTemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }
        public async Task<IEnumerable<TblTemplate>> GetTemplatesAsync()
        {
            return await _templateRepository.GetTemplatesAsync();
        }

        public async Task<IEnumerable<TblTemplate>> ReturnWithActions(int muniId)
        {
            return await _templateRepository.ReturnWithActions(muniId);
        }
    }
}
