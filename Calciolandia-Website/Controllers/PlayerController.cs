using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Calciolandia_Website.Core.Services;
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

        public async Task<IActionResult> Index()
        {
            var model = await playerService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new PlayerViewModel()
            {
                FootballClubs = await playerService.GetAllFootballClubsAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PlayerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await playerService.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for player");

                return View(model);
            }
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await playerService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await playerService.GetForEditAsync(id);

            model.FootballClubs = await playerService.GetAllFootballClubsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PlayerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await playerService.EditAsync(model);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for player");

                return View(model);
            }
        }
    }
}
