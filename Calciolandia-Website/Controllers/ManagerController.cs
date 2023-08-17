using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Controllers
{
    public class ManagerController : BaseController
    {
        private readonly IManagerService managerService;

        public ManagerController(IManagerService _managerService)
        {
            managerService = _managerService;
        }

        //public async Task<IActionResult> Index()
        //{
        //    //var model = await managerService.GetAllAsync();

        //    //return View(model);
        //}

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add()
        {
            var model = new ManagerViewModel()
            {
                FootballClubs = await managerService.GetFootballClubsAsync()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Add(ManagerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await managerService.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for manager");
                return View(model);
            }
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Delete(Guid id)
        {
           await managerService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await managerService.GetForEditAsync(id);

            model.FootballClubs = await managerService.GetFootballClubsAsync();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = RoleConstants.Admin)]
        public async Task<IActionResult> Edit(ManagerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await managerService.EditAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for manager");
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Info(Guid id)
        {
            var model = await managerService.GetManagerById(id);

            return View(model);
        }

       
    }
}
