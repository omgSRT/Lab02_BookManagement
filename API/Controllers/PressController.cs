using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Service.Interface;
using Service.Service;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PressController : ControllerBase
    {
        private readonly IPressService _pressService;
        public PressController(IPressService pressService)
        {
            _pressService = pressService;
        }
        [EnableQuery(PageSize = 10)]
        [HttpGet("get")]
        public IActionResult GetAllPresses()
        {
            try
            {
                var list = _pressService.GetAll().Result!.AsQueryable();
                if (list.Any())
                {
                    return Ok(list);
                }
                return NotFound("There's No Data");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
