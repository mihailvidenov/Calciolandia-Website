using Calciolandia_Website.Core.Contracts;
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
    public class OwnerService : IOwnerService
    {
        private readonly IRepository repo;

        public OwnerService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddAsync(OwnerViewModel model)
        {
            var owner = new Owner()
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Age = model.Age,
                Nationality = model.Nationality,
                BirthDate = model.BirthDate,
                FootballClubId = model.FootballClubId
            };

            await repo.AddAsync(owner);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var owner = await repo.GetByIdAsync<Owner>(id);

            if (owner != null)
            {
                owner.IsDeleted = true;
                await repo.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<OwnerViewModel>> GetAllAsync()
        {
            var entities = await repo.AllReadonly<Owner>()
                .Where(o => o.IsDeleted == false)
                .ToListAsync();

            return entities.Select(e => new OwnerViewModel()
            {
                FirstName = e.FirstName,
                MiddleName = e.MiddleName,
                LastName = e.LastName,
                Age = e.Age,
                Nationality = e.Nationality,
                BirthDate = e.BirthDate,
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
