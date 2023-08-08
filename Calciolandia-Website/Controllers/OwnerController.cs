using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class OwnerController : BaseController
    {
        private readonly IOwnerService ownerService;

        public OwnerController(IOwnerService _ownerService)
        {
            ownerService = _ownerService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await ownerService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new OwnerViewModel()
            {
                FootballClubs = await ownerService.GetAllFootballClubsAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(OwnerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await ownerService.AddAsync(model);
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
            await ownerService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
