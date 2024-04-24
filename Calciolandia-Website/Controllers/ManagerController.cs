using Calciolandia_Website.Areas.Admin;
using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class ManagerController : BaseController
    {
        private readonly IManagerService managerService;

        public ManagerController(IManagerService _managerService)
        {
            managerService = _managerService;
        }

       

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add()
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(Manager), new { area = "Admin" });
            }

            var model = new ManagerViewModel()
            {
                FootballClubs = await managerService.GetFootballClubsAsync()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(ManagerViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(Manager), new { area = "Admin" });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await managerService.AddAsync(model);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for manager");
                return View(model);
            }
        }

      
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Delete), nameof(Manager), new { area = "Admin" });
            }

            await managerService.DeleteAsync(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(Manager), new { area = "Admin" });
            }
            var model = await managerService.GetForEditAsync(id);

            model.FootballClubs = await managerService.GetFootballClubsAsync();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(ManagerViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(Manager), new { area = "Admin" });
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await managerService.EditAsync(model);
                return RedirectToAction("Info", "Manager", new { id = model.Id });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for manager");
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Info(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Info), nameof(Manager), new { area = "Admin" });
            }
            var model = await managerService.GetManagerById(id);

            return View(model);
        }

       
    }
}
