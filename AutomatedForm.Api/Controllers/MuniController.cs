using AutoMapper;
using AutomatedForm.Core.DTOs;
using AutomatedForm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedForm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuniController : ControllerBase
    {
        private readonly ITblMuniService _muniService;
        private readonly IMapper _mapper;
        public MuniController(ITblMuniService muniService, IMapper mapper)
        {
            _muniService = muniService;
            _mapper = mapper;
        }


 

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MuniDTO>>> Get()
        {
            // קבלת רשימת הסניפים ישירות מהשירות
            var list = await _muniService.GetMunisAsync();

            // החזרת הרשימה כפי שהיא
            return Ok(list);
        }
    }
}
