using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Service.Interface;
using Service.Service;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [EnableQuery(PageSize = 10)]
        [HttpGet("getall")]
        public IActionResult GetAllBooksAsync()
        {
            try
            {
                var list = _addressService.GetAll().Result!.AsQueryable();
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
