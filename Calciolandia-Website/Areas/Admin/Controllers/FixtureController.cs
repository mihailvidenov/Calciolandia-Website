using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Areas.Admin.Controllers
{
    public class FixtureController : AdminController
    {
        private readonly IFixtureService fixtureService;

        public FixtureController(IFixtureService _fixtureService)
        {
            this.fixtureService = _fixtureService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = await fixtureService.GetAllFixturesByLeague(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddFixtureViewModel()
            {
                Stadiums = await fixtureService.GetStadiumsAsync(),
                Leagues = await fixtureService.GetLeaguesAsync(),
                HomeTeams = await fixtureService.GetFootballClubsAsync(),
                AwayTeams = await fixtureService.GetFootballClubsAsync()

            };


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddFixtureViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await fixtureService.AddAsync(model);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for fixture");

                return View(model);
            }

        }

        
        public async Task<IActionResult> Delete(Guid id)
        {
            await fixtureService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await fixtureService.GetForEditAsync(id);


            model.Stadiums = await fixtureService.GetStadiumsAsync();
            model.Leagues = await fixtureService.GetLeaguesAsync();
            model.HomeTeams = await fixtureService.GetFootballClubsAsync();
            model.AwayTeams = await fixtureService.GetFootballClubsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AddFixtureViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await fixtureService.EditAsync(model);
                return RedirectToAction("Index", "Fixtures", new { id = model.LeagueId });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for fixture");

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOne(Guid id)
        {
            var model = await fixtureService.GetFixtureAsync(id);


            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetByRound(int round)
        {
            var model = await fixtureService.GetAllFixturesByRound(round);


            return View(model);
        }
    }
}
