using AutomatedForm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.Services
{
    public interface ITransMuniLabService
    {
        Task<IEnumerable<TransMuniLab>> GetMuniLabAsync();
        Task<TblLaboratory> GetLabByMuniIdAsync(int id);
    }
}
