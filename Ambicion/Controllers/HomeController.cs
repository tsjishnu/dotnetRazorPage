using Microsoft.AspNetCore.Mvc;

namespace Ambicion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
