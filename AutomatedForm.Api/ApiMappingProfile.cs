using AutoMapper;
using AutomatedForm.Api.Models;
using AutomatedForm.Core.Models;
using System.Data;

namespace AutomatedForm.Api
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<BranchPostModel, TblBranch>().ReverseMap();
        }
    }
}
