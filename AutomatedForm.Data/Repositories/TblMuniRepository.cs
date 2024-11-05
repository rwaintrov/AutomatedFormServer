
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
    public class TblMuniRepository: ITblMuniRepository
    {
        private readonly DataContext _context;

        public TblMuniRepository(DataContext context)
        {
            _context = context;
        }





        public async Task<IEnumerable<TblMuni>> GetMunisAsync()
        {
            return await _context.TblMuni.ToListAsync();
        }
    }
}
