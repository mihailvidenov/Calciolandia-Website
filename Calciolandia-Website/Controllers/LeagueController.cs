using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models.League;
using Calciolandia_Website.Core.Services;
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
            var model = await leagueService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new LeagueViewModel();

            return View(model);
        }

        public async Task<IActionResult> Add(LeagueViewModel model)
        {
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

        public async Task<IActionResult> Delete(int id)
        {
            await leagueService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));

        }
    }
}
