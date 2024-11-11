using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Repository.Interface;
using Service.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [EnableQuery(PageSize = 10)]
        [HttpGet("get")]
        public IActionResult GetAllBooksAsync()
        {
            try
            {
                var list = _categoryService.GetAllWith2Include("Address", "Press").Result!.AsQueryable();
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
