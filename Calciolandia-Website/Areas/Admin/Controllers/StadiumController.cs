using Calciolandia_Website.Core.Constants;
using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Calciolandia_Website.Areas.Admin.Controllers
{
    public class StadiumController : AdminController
    {
		private readonly IStadiumService stadiumService;

		public StadiumController(IStadiumService _stadiumService)
		{
			stadiumService = _stadiumService;
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
				return RedirectToAction("Index", "Home");
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

			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = await stadiumService.GetForEditAsync(id);

			return View(model);
		}

		[HttpPost]
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
