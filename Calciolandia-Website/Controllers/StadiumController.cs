using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Calciolandia_Website.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Controllers
{
    public class StadiumController : BaseController
    {
        private readonly IStadiumService stadiumService;

        public StadiumController(IStadiumService _stadiumService)
        {
            stadiumService = _stadiumService;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var model = await stadiumService.GetAllAsync();

        //    return View(model);
        //}

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public IActionResult Add()
        {
            var model = new StadiumViewModel();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(StadiumViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await stadiumService.AddAsync(model);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for stadium");
                return View(model);
            }
        }

        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            await stadiumService.DeleteAsync(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await stadiumService.GetForEditAsync(id);

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(StadiumViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await stadiumService.EditAsync(model);

                return RedirectToAction("Info", "Stadium", new { id = model.Id });
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for stadium");

                return View(model);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Info(int id)
        {
            var model = await stadiumService.GetStadiumById(id);

            return View(model);
        }
    }
}
