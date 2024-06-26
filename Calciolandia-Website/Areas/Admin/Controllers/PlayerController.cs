﻿using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Areas.Admin.Controllers
{
    public class PlayerController : AdminController
    {
		private readonly IPlayerService playerService;

		public PlayerController(IPlayerService _playerService)
		{
			playerService = _playerService;
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
				return RedirectToAction("Index", "Home");
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

			return RedirectToAction("Index", "Home");
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

				return RedirectToAction("Info", "Player", new { id = model.Id });
			}
			catch (Exception)
			{
				ModelState.AddModelError("", "Invalid data for player");

				return View(model);
			}
		}

		[HttpGet]
		public async Task<IActionResult> Info(Guid id)
		{
			var model = await playerService.GetPlayerById(id);


			return View(model);
		}
	}
}
