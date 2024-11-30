using AutoMapper;
using AutomatedForm.Core.DTOs;
using AutomatedForm.Core.Services;
using AutomatedForm.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedForm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratoryController : ControllerBase
    {
        private readonly ITblLaboratoryService _laboratoryService;
        private readonly IMapper _mapper;
        public LaboratoryController(ITblLaboratoryService laboratoryService, IMapper mapper)
        {
            _laboratoryService = laboratoryService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<LaboratoryDTO>>> Get()
        {
            // קבלת רשימת הסניפים ישירות מהשירות
            var list = await _laboratoryService.GetLaboratoriesAsync();

            // החזרת הרשימה כפי שהיא
            return Ok(list);
        }

    }
}
