using Microsoft.AspNetCore.Mvc;

namespace Verify.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
