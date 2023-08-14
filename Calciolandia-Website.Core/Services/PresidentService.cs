﻿using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Common;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Services
{
    public class PresidentService : IPresidentService
    {
        private readonly IRepository repo;

        public PresidentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddAsync(PresidentViewModel model)
        {
            var owner = new President()
            {
                FirstName = model.FirstName,
                //MiddleName = model.MiddleName,
                LastName = model.LastName,
                Age = model.Age,
                Nationality = model.Nationality,
                BirthDate = model.BirthDate,
                ImageUrl = model.ImageUrl,
                FootballClubId = model.FootballClubId
            };

            await repo.AddAsync(owner);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var owner = await repo.GetByIdAsync<President>(id);

            if (owner != null)
            {
                owner.IsDeleted = true;
                await repo.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<PresidentViewModel>> GetAllAsync()
        {
            var entities = await repo.AllReadonly<President>()
                .Where(o => o.IsDeleted == false)
                .ToListAsync();

            return entities.Select(e => new PresidentViewModel()
            {
                FirstName = e.FirstName,
                //MiddleName = e.MiddleName,
                LastName = e.LastName,
                Age = e.Age,
                Nationality = e.Nationality,
                BirthDate = e.BirthDate,
                ImageUrl = e.ImageUrl,
                FootballClubId = e.FootballClubId
            });
        }

        public async Task<IEnumerable<FootballClub>> GetAllFootballClubsAsync()
        {
            return await repo.All<FootballClub>()
                .Where(f => f.IsDeleted == false)
                .ToListAsync();
        }
    }
}