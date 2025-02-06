using Microsoft.AspNetCore.Mvc;

namespace photo_world.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
