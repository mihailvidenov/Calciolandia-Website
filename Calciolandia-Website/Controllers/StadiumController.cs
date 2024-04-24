using Calciolandia_Website.Areas.Admin;
using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class StadiumController : BaseController
    {
        private readonly IStadiumService stadiumService;

        public StadiumController(IStadiumService _stadiumService)
        {
            stadiumService = _stadiumService;
        }

       

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public IActionResult Add()
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(Stadium), new { area = "Admin" });
            }
            var model = new StadiumViewModel();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(StadiumViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(Stadium), new { area = "Admin" });
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await stadiumService.AddAsync(model);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for stadium");
                return View(model);
            }
        }

        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Delete), nameof(Stadium), new { area = "Admin" });
            }
            await stadiumService.DeleteAsync(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(int id)
        {

            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(Stadium), new { area = "Admin" });
            }
            var model = await stadiumService.GetForEditAsync(id);

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(StadiumViewModel model)
        {

            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(Stadium), new { area = "Admin" });
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await stadiumService.EditAsync(model);

                return RedirectToAction("Info", "Stadium", new { id = model.Id });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for stadium");

                return View(model);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Info(int id)
        {

            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Info), nameof(Stadium), new { area = "Admin" });
            }
            var model = await stadiumService.GetStadiumById(id);

            return View(model);
        }
    }
}
