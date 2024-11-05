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
    public class TblFactoryRepository:ITblFactoryRepository
    {
        private readonly DataContext _context;

        public TblFactoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblFactory>> GetFactorysAsync()
        {
            return await _context.TblFactory.ToListAsync();
        }
    }
}
