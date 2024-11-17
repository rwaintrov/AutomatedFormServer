using AutoMapper;
using AutomatedForm.Core.DTOs;
using AutomatedForm.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedForm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly ITblTemplateService _templateService;
        private readonly IMapper _mapper;
        public TemplateController(ITblTemplateService templateService, IMapper mapper)
        {
            _templateService = templateService;
            _mapper = mapper;
        }
        [HttpGet("return-with-action/{muniId}")]
        public async Task<ActionResult<IEnumerable<TemplateDTO>>> ReturnWithActions(int muniId)
        {
            // פנייה לשירות לקבלת התבניות
            var templates = await _templateService.ReturnWithActions(muniId);

            // אם אין תבניות, מחזיר תגובה של NotFound
            if (templates == null || !templates.Any())
            {
                return NotFound("לא נמצאו תבניות למספר מועצה זה.");
            }

            // מיפוי התוצאות לאובייקט DTO
            var templatesDto = _mapper.Map<IEnumerable<TemplateDTO>>(templates);

            // מחזיר את רשימת התבניות כ-OK
            return Ok(templatesDto);
        }




    }
}
