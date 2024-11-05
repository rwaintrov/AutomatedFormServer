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
        public async Task<IEnumerable<TransMuniFactory>> GetMuniFactorysByIdMuniAsync(int id)
        {
            //return await _context.TransMuniFactory.ToListAsync();
            return await _context.TransMuniFactory
        .Where(obj => obj.MuniId == id)
        .ToListAsync();
        }

    }
}
