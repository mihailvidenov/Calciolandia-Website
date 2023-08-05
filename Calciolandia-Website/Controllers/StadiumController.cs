using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
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

        public async Task<IActionResult> Index()
        {
            var model = await stadiumService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new StadiumViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StadiumViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await stadiumService.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for stadium");
                return View(model);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            await stadiumService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
