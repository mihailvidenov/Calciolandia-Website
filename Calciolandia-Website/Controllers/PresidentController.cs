using Calciolandia_Website.Areas.Admin;
using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Calciolandia_Website.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Controllers
{
    public class PresidentController : BaseController
    {
        private readonly IPresidentService presidentService;

        public PresidentController(IPresidentService _presidentService)
        {
            presidentService = _presidentService;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var model = await presidentService.GetAllAsync();

        //    return View(model);
        //}

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add()
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(President), new { area = "Admin" });
            }
            var model = new PresidentViewModel()
            {
                FootballClubs = await presidentService.GetAllFootballClubsAsync()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(PresidentViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(President), new { area = "Admin" });
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await presidentService.AddAsync(model);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for owner");

                return View(model);
            }
        }

       
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Delete), nameof(President), new { area = "Admin" });
            }
            await presidentService.DeleteAsync(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(President), new { area = "Admin" });
            }
            var model = await presidentService.GetForEditAsync(id);

            model.FootballClubs = await presidentService.GetAllFootballClubsAsync();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(PresidentViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(President), new { area = "Admin" });
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await presidentService.EditAsync(model);

                return RedirectToAction("Info", "President", new { id = model.Id });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for president");

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Info(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Info), nameof(President), new { area = "Admin" });
            }

            var model = await presidentService.GetPresidentById(id);

            return View(model);
        }
    }
}
