using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
