using AutoMapper;
using AutomatedForm.Core.DTOs;
using AutomatedForm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedForm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuniLabController : ControllerBase
    {
        private readonly ITransMuniLabService _muniLabService;
        private readonly IMapper _mapper;
        public MuniLabController(ITransMuniLabService muniLabService, IMapper mapper)
        {
            _muniLabService = muniLabService;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<MuniLabDTO>>> Get()
        {
            // קבלת רשימת הסניפים ישירות מהשירות
            var list = await _muniLabService.GetMuniLabAsync();

            // החזרת הרשימה כפי שהיא
            return Ok(list);
        }

        //[HttpGet("lab-by-muni/{id}")]
        //public async Task<ActionResult<IEnumerable<FactoryDTO>>> GetFactoriesByMuniIdAsync(int id)
        //{
        //    // שליפת רשימת המפעלים הקשורים ל-MuniId מסוים
        //    var lab = await _muniLabService.GetLabByMuniIdAsync(id);

        //    // מיפוי הרשימה ל-DTO להחזרה
        //    var labDTO = lab.Select(f => _mapper.Map<LaboratoryDTO>(f));

        //    return Ok(labDTO);
        //}
        [HttpGet("lab-by-muni/{id}")]
        public async Task<ActionResult<LaboratoryDTO>> GetLabByMuniIdAsync(int id)
        {
            // שליפת המעבדה הקשורה ל-MuniId מסוים
            var lab = await _muniLabService.GetLabByMuniIdAsync(id);

            // אם לא נמצאה מעבדה, מחזירים אובייקט ריק עם סטטוס 200 OK
            if (lab == null)
            {
                return Ok(new LaboratoryDTO()); // מחזיר אובייקט ריק (או null אם זה מתאים יותר)
            }

            // מיפוי המעבדה ל-DTO
            var labDTO = _mapper.Map<LaboratoryDTO>(lab);

            return Ok(labDTO); // מחזיר את ה-DTO
        }
    }
}
