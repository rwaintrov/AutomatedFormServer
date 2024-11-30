using AutomatedForm.Core.Models;
using AutomatedForm.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Data.Repositories
{
    public class TblTemplateRepository : ITblTemplateRepository
    {
        private readonly DataContext _context;
        private readonly ITransMuniFactoryRepository _transMuniFactoryRepository;
        private readonly ITransMuniLabRepository _transMuniLabRepository;

        public TblTemplateRepository(DataContext context,
            ITransMuniFactoryRepository transMuniFactoryRepository, ITransMuniLabRepository transMuniLabRepository
            )
        {
            _context = context;
            _transMuniFactoryRepository = transMuniFactoryRepository;
            _transMuniLabRepository = transMuniLabRepository;
        }


 
public async Task<IEnumerable<TblTemplate>> ReturnWithActions(int muniId)
        {
            //int templateId = 40;
            var factories = await _transMuniFactoryRepository.GetFactoriesByMuniIdAsync(muniId);
            var lab = await _transMuniLabRepository.GetLabByMuniIdAsync(muniId);

            if (factories == null || !factories.Any())
            {
                return Enumerable.Empty<TblTemplate>(); // מחזיר רשימה ריקה אם לא נמצאו מפעלים
            }

            var templates = factories.Select(factory => new TblTemplate
            {
                MuniId = muniId,
                TemplateName = "תבנית עם פרטי מפעל",
                TemplateJson = JsonConvert.SerializeObject(new
                {
                    Factory = factory.FactoryName,
                    Address = factory.FactoryAddress,
                    LabName = lab.LabName,
                }),
                IsActive = true,
                IsDeleted = false
            }).ToList();

            // שומר את כל התבניות בבסיס הנתונים
            _context.TblTemplate.AddRange(templates);
            await _context.SaveChangesAsync();

            return templates; // מחזיר את כל התבניות שנוצרו
        }
        //return res;



        public async Task<IEnumerable<TblTemplate>> GetTemplatesAsync()
        {
            return await _context.TblTemplate.ToListAsync();
        }
        //public Task<IEnumerable<TblTemplate>> GetTemplatesAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<TblTemplate>> ReturnWithActions(int muniId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
