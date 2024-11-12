using AutoMapper;
using AutomatedForm.Core.DTOs;
using AutomatedForm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedForm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuniFactoryController : ControllerBase
    {
        private readonly ITransMuniFactoryService _muniFactoryService;
        private readonly IMapper _mapper;
        public MuniFactoryController(ITransMuniFactoryService muniFactoryService, IMapper mapper)
        {
            _muniFactoryService = muniFactoryService;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<MuniFactoryDTO>>> Get()
        {
            // קבלת רשימת הסניפים ישירות מהשירות
            var list = await _muniFactoryService.GetMuniFactorysAsync();

            // החזרת הרשימה כפי שהיא
            return Ok(list);
        }
     
        [HttpGet("factories-by-muni/{id}")]
        public async Task<ActionResult<IEnumerable<FactoryDTO>>> GetFactoriesByMuniIdAsync(int id)
        {
            // שליפת רשימת המפעלים הקשורים ל-MuniId מסוים
            var factories = await _muniFactoryService.GetFactoriesByMuniIdAsync(id);

            // מיפוי הרשימה ל-DTO להחזרה
            var factoryDTOs = factories.Select(f => _mapper.Map<FactoryDTO>(f));

            return Ok(factoryDTOs);
        }
    }
}
