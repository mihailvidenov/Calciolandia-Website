using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Areas.Admin.Controllers
{
    public class PresidentController : AdminController
    {
        private readonly IPresidentService presidentService;

        public PresidentController(IPresidentService _presidentService)
        {
            presidentService = _presidentService;
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
                return RedirectToAction("Index", "Home");
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

            return RedirectToAction("Index", "Home");
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


            var model = await presidentService.GetPresidentById(id);

            return View(model);
        }
    }

}
