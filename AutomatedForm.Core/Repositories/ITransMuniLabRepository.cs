using AutomatedForm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.Repositories
{
    public interface ITransMuniLabRepository
    {
        Task<IEnumerable<TransMuniLab>> GetMuniLabsAsync();
        Task<TblLaboratory> GetLabByMuniIdAsync(int id);
    }
}
