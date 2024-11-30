using AutoMapper;
using AutomatedForm.Core.DTOs;
using AutomatedForm.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BranchDTO, TblBranch>().ReverseMap();
            CreateMap<TemplateDTO, TblTemplate>().ReverseMap();
            CreateMap<MuniDTO, TblMuni>().ReverseMap();
            CreateMap<FactoryDTO, TblFactory>().ReverseMap();
            CreateMap<MuniFactoryDTO, TransMuniFactory>().ReverseMap();
            CreateMap<MuniLabDTO, TransMuniLab>().ReverseMap();
            CreateMap<LaboratoryDTO, TblLaboratory>().ReverseMap();
        }
    }
}
