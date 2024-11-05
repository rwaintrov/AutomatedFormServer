using AutomatedForm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.Repositories
{
    public interface ITblMuniRepository
    {
        Task<IEnumerable<TblMuni>> GetMunisAsync();
        //Task<int?> GetMuniByNameAsync(int id);
    }
}
