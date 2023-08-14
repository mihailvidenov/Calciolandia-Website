using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class PresidentController : BaseController
    {
        private readonly IPresidentService presidentService;

        public PresidentController(IPresidentService _presidentService)
        {
            presidentService = _presidentService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await presidentService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new PresidentViewModel()
            {
                FootballClubs = await presidentService.GetAllFootballClubsAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PresidentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await presidentService.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for owner");

                return View(model);
            }
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await presidentService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await presidentService.GetForEditAsync(id);

            model.FootballClubs = await presidentService.GetAllFootballClubsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PresidentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await presidentService.EditAsync(model);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for president");

                return View(model);
            }
        }
    }
}
