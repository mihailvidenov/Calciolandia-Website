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
    public class LeagueService : ILeagueService
    {
        private readonly IRepository repo;

        public LeagueService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddAsync(LeagueViewModel model)
        {
            var league = new League()
            {
                Name = model.Name,
                Country = model.Country,
                LogoImageUrl = model.LogoImageUrl
            };

            await repo.AddAsync(league);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var league = await repo.GetByIdAsync<League>(id);

            if (league != null)
            {
                league.IsDeleted = true;

                await repo.SaveChangesAsync();
            }
        }

        public async Task EditAsync(LeagueViewModel model)
        {
            var league = await repo.GetByIdAsync<League>(model.Id);
            
            league.Name = model.Name;
            league.Country = model.Country;
            league.LogoImageUrl = model.LogoImageUrl;

            await repo.SaveChangesAsync();

        }

        //public async Task EditAsync(LeagueViewModel model)
        //{

        //}

        public async Task<IEnumerable<LeagueViewModel>> GetAllAsync()
        {
            var entities = await repo.AllReadonly<League>()
                .Where(l => l.IsDeleted == false).ToListAsync();

            return entities
                .Select(l => new LeagueViewModel()
                {
                    Id = l.Id,
                    Name = l.Name,
                    Country = l.Country,
                    LogoImageUrl = l.LogoImageUrl
                });
        }

        public async Task<LeagueViewModel> GetForEditAsync(int id)
        {
            var league = await repo.GetByIdAsync<League>(id);

            var model = new LeagueViewModel()
            {
                Id = league.Id,
                Name = league.Name,
                Country = league.Country,
                LogoImageUrl = league.LogoImageUrl
            };

            return model;

        }

        //public async Task<LeagueViewModel> GetByIdAsync(int id)
        //{
        //    var league = await repo.GetByIdAsync<League>(id);

        //    return new LeagueViewModel()
        //    {
        //        Name = league.Name,
        //        Country = league.Country,
        //        LogoImageUrl = league.LogoImageUrl
        //    };
        //}
    }
}
