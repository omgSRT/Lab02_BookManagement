using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
