using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Areas.Admin.Controllers
{
    [Area(AdminConstants.AreaName)]
    [Authorize(Roles = AdminConstants.AdminRoleName)]
    public class AdminController : Controller
    {
    }
}
