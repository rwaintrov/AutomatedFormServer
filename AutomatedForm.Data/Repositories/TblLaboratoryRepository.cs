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
    public class TblLaboratoryRepository:ITblLaboratoryRepository
    {
        private readonly DataContext _context;

        public TblLaboratoryRepository(DataContext context)
        {
            _context = context;
        }





        public async Task<IEnumerable<TblLaboratory>> GetLaboratoriesAsync()
        {
            return await _context.TblLaboratory.ToListAsync();
        }

    }
}
