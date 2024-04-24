using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
       
    }
}
