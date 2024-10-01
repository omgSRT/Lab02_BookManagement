using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
