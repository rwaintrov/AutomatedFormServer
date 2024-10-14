//using AutomatedForm.Core.Entities;
using AutomatedForm.Core.Repositories;
using AutomatedForm.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Data.Repositories
{
    public class AuthorityRepository:IAuthorityRepository 
    {
        private readonly DataContext _context;
        public AuthorityRepository(DataContext context)
        {
            _context = context;
        }

       //public async Task<IEnumerable<Form>> GetFormsAsync()
       //{
       //     //return await _context.Forms.ToListAsync();
       //}
    }
}
