using AutomatedForm.Core.Models;
using AutomatedForm.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Data.Repositories
{
    public class TransMuniFactoryRepository:ITransMuniFactoryRepository
    {
        private readonly DataContext _context;

        public TransMuniFactoryRepository(DataContext context)
        {
            _context = context;
        }





        public async Task<IEnumerable<TransMuniFactory>> GetMuniFactorysAsync()
        {
            return await _context.TransMuniFactory.ToListAsync();
        } 
  






        public async Task<IEnumerable<TblFactory>> GetFactoriesByMuniIdAsync(int muniId)
        {
            // שליפת כל השורות בטבלת MUNIFACTORY עם muniId מתאים
            var muniFactories = await _context.TransMuniFactory
                                               .Where(mf => mf.MuniId == muniId)
                                               .ToListAsync();

            // יצירת רשימת factoryId
            var factoryIds = muniFactories.Select(mf => mf.FactoryId).ToList();

            // שליפת נתונים מטבלת FACTORY לפי factoryId
            var factories = await _context.TblFactory
                                           .Where(f => factoryIds.Contains(f.FactoryId))
                                           .ToListAsync();

            return factories;
        }
    }
}
