using AutomatedForm.Core.Models;
using AutomatedForm.Core.Repositories;
using AutomatedForm.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Service
{
    public class BranchService:ITblBranchService
    {
        private readonly ITblBranchRepository _branchRepository;
        public BranchService(ITblBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }
        public async Task<IEnumerable<TblBranch>> GetBranchesAsync()
        {
            return await _branchRepository.GetBranchesAsync();
        }
    }
}
