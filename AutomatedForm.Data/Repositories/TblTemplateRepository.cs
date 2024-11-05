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
    public class TblTemplateRepository:ITblTemplateRepository
    {
        private readonly DataContext _context;

        public TblTemplateRepository(DataContext context)
        {
            _context = context;
        }





        public async Task<IEnumerable<TblTemplate>> GetTemplatesAsync()
        {
            return await _context.TblTemplate.ToListAsync();
        }
    }
}
