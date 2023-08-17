using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Calciolandia_Website.Controllers
{
    public class FootballClubController : BaseController
    {
        private readonly IFootballClubService footballClubService;

        public FootballClubController(IFootballClubService _footballClubService)
        {
            footballClubService = _footballClubService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await footballClubService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add()
        {
            var model = new FootballClubViewModel()
            {
                Leagues = await footballClubService.GetLeaguesAsync(),
                Stadiums = await footballClubService.GetStadiumsAsync()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(FootballClubViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await footballClubService.AddAsync(model);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for football club");

                return View(model);
            }
        }

        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            await footballClubService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await footballClubService.GetForEditAsync(id);

            model.Leagues = await footballClubService.GetLeaguesAsync();
            model.Stadiums = await footballClubService.GetStadiumsAsync();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(FootballClubViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await footballClubService.EditAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for football club");

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOne(int id)
        {
            var model = await footballClubService.GetFootballClubAsync(id);

            model.Players = await footballClubService.GetPlayersByFootballClub(id);
            model.Presidents = await footballClubService.GetPresidentByFootballClub(id);
            model.Managers = await footballClubService.GetManagersByFootballClub(id);
            model.Stadiums = await footballClubService.GetStadiumById(id);

            return View(model);
        }
    }
}
