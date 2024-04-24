using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Calciolandia_Website.Areas.Admin;
using System.Net.Mail;

namespace Calciolandia_Website.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {

            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Index),"Home", new { area = "Admin" });
            }

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}