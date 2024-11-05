using AutoMapper;
using AutomatedForm.Core.DTOs;
using AutomatedForm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedForm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        private readonly ITblFactoryService _factoryService;
        private readonly IMapper _mapper;
        public FactoryController(ITblFactoryService factoryService, IMapper mapper)
        {
            _factoryService = factoryService;
            _mapper = mapper;
        }


        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<BranchDTO>>> Get()
        //{
        //    var list = await _branchService.GetBranchesAsync();
        //    var list1 = list.Select(d => _mapper.Map<BranchDTO>(d));
        //    // להחזיר רק את העובדים שהדרוג הגבוה ביותר שלהם הוא שווה או פחות מהדרוג הגבוה של מבקש הבקשה
        //    return Ok(list1);
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FactoryDTO>>> Get()
        {
            // קבלת רשימת הסניפים ישירות מהשירות
            var list = await _factoryService.GetFactorysAsync();

            // החזרת הרשימה כפי שהיא
            return Ok(list);
        }


    }
}
