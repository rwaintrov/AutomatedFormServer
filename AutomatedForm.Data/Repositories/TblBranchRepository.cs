using AutomatedForm.Core.Models;
using AutomatedForm.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Data.Repositories
{
    public class TblBranchRepository: ITblBranchRepository
    {
        private readonly DataContext _context;
       
        public TblBranchRepository(DataContext context)
        {
            _context = context;
        }





        public async Task<IEnumerable<TblBranch>> GetBranchesAsync()
        { 
            return await _context.TblBranch.ToListAsync();
        }



    }
}
