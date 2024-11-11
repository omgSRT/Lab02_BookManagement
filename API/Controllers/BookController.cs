using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Service.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [EnableQuery(PageSize = 10)]
        [HttpGet("get")]
        public IActionResult GetAllBooksAsync()
        {
            try
            {
                var list = _bookService.GetAll().Result!.AsQueryable();
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
