using Calciolandia_Website.Areas.Admin;
using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class PlayerController : BaseController
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService _playerService)
        {
            playerService = _playerService;
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add()
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(Player), new { area = "Admin" });
            }
            var model = new PlayerViewModel()
            {
                FootballClubs = await playerService.GetAllFootballClubsAsync()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(PlayerViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Add), nameof(Player), new { area = "Admin" });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await playerService.AddAsync(model);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for player");

                return View(model);
            }
        }

    
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Delete), nameof(Player), new { area = "Admin" });
            }

            await playerService.DeleteAsync(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(Player), new { area = "Admin" });
            }

            var model = await playerService.GetForEditAsync(id);

            model.FootballClubs = await playerService.GetAllFootballClubsAsync();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(PlayerViewModel model)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Edit), nameof(Player), new { area = "Admin" });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await playerService.EditAsync(model);

                return RedirectToAction("Info", "Player", new { id = model.Id} );
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for player");

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Info(Guid id)
        {
            if (this.User.IsInRole(AdminConstants.AdminRoleName))
            {
                return RedirectToAction(nameof(Info), nameof(Player), new { area = "Admin" });
            }

            var model = await playerService.GetPlayerById(id);


            return View(model);
        }
    }
}
