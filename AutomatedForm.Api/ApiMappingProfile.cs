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
            CreateMap<BranchPostModel, Models.TblBranch>().ReverseMap();
            CreateMap<MuniPostModel, Models.TblMuni>().ReverseMap();
            CreateMap<FactoryPostModel, Models.TblFactory>().ReverseMap();
            CreateMap<MuniFactoryPostModel, Models.TransMuniFactory>().ReverseMap();
            CreateMap<MuniLabPostModel, Models.TransMuniLab>().ReverseMap();
            CreateMap<LaboratoryPostModel, Models.TblLaboratory>().ReverseMap();
        }
    }
}
