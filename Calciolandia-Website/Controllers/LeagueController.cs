using Calciolandia_Website.Areas.Admin;
using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class LeagueController : BaseController
    {
        private readonly ILeagueService leagueService;

        public LeagueController(ILeagueService _leagueService)
        {
            leagueService = _leagueService;
        }

        public async Task<IActionResult> Index()
        {

            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Index), nameof(League), new { area = "Admin" });
            }

            var model = await leagueService.GetAllAsync();

            return View(model);


        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public IActionResult Add()
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(League), new { area = "Admin" });
            }

            var model = new LeagueViewModel();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(LeagueViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(League), new { area = "Admin" });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await leagueService.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Invalid data for league");

                return View(model);
            }
        }

        
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Delete), nameof(League), new { area = "Admin" });
            }
            await leagueService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(int id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(League), new { area = "Admin" });
            }
            var model = await leagueService.GetForEditAsync(id);

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(LeagueViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(League), new { area = "Admin" });
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await leagueService.EditAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for league");
                return View(model);
            }
        }
    }
}
