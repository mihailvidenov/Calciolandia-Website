﻿using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calciolandia_Website.Controllers
{
    public class FootballClubController : Controller
    {
        private readonly IFootballClubService footballClubService;

        public FootballClubController(IFootballClubService _footballClubService)
        {
            footballClubService = _footballClubService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await footballClubService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new FootballClubViewModel()
            {
                Leagues = await footballClubService.GetLeaguesAsync(),
                Stadiums = await footballClubService.GetStadiumsAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(FootballClubViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await footballClubService.AddAsync(model);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Invalid data for football club");

                return View(model);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            await footballClubService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
