﻿
using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Areas.Admin.Controllers
{
    public class LeagueController : AdminController
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

        [HttpPost]
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await leagueService.GetForEditAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(LeagueViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await leagueService.EditAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for league");
                return View(model);
            }
        }
    }
}
