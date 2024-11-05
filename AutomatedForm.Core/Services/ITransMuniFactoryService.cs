using AutomatedForm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.Services
{
    public interface ITransMuniFactoryService
    {
        Task<IEnumerable<TransMuniFactory>> GetMuniFactorysAsync();
        Task<IEnumerable<TransMuniFactory>> GetMuniFactorysByIdMuniAsync(int id);
    }
}
