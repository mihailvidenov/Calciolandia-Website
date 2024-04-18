using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Error/{statusCode}")]
        public IActionResult Error(int? statusCode)
        {
            if (statusCode.HasValue)
            {
                if (statusCode == 404)
                {
                     return View(nameof(NotFound));
                }
                else if (statusCode == 500)
                {
                    return View(nameof(BadRequest));
                }
                else
                {
                    return View(nameof(Error));
                }

            }
            return View();
        }
    }
}
