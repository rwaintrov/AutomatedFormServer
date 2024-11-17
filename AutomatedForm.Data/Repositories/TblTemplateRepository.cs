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

        public TblTemplateRepository(DataContext context,
            ITransMuniFactoryRepository transMuniFactoryRepository
            )
        {
            _context = context;
            _transMuniFactoryRepository = transMuniFactoryRepository;
        }

        public async Task<IEnumerable<TblTemplate>> ReturnWithActions(int muniId)
        {
            var res = await _transMuniFactoryRepository.GetFactoriesByMuniIdAsync(muniId);

            if (res == null || !res.Any())
            {
                return Enumerable.Empty<TblTemplate>(); // מחזיר רשימה ריקה אם לא נמצאו מפעלים
            }

            // לוקח את המפעל הראשון
            var firstFactory = res.First();

            // יוצר מופע חדש של TblTemplate ומכניס את המידע של המפעל הראשון כ-JSON
            var template = new TblTemplate
            {
                TemplateId=2,
                MuniId = muniId,
                TemplateName = "תבנית עם פרטי מפעל",
                TemplateJson = JsonConvert.SerializeObject(new
                {
                    Factory = firstFactory.FactoryName,
                    Address = firstFactory.FactoryAddress // מניח שלמפעל יש שדה כתובת
                }),
                IsActive = true,
                IsDeleted = false
            };

            // שומר את התבנית החדשה בבסיס הנתונים
            _context.TblTemplate.Add(template);
            await _context.SaveChangesAsync();

            // מחזיר את התבנית החדשה ברשימה
            return new List<TblTemplate> { template };
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
