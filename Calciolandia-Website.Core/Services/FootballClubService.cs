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
    public class FootballClubService : IFootballClubService
    {
        private readonly IRepository repo;
        public FootballClubService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task AddAsync(FootballClubViewModel model)
        {
            var footballClub = new FootballClub()
            {
                Name = model.Name,
                Nickname = model.Nickname,
                Address = model.Address,
                City = model.City,
                LogoImageUrl = model.LogoImageUrl,
                FoundedYear = model.FoundedYear,
                Trophies = model.Trophies,
                StadiumId = model.StadiumId,
                LeagueId = model.LeagueId
            };

            await repo.AddAsync(footballClub);
            await repo.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var footballClub = await repo.GetByIdAsync<FootballClub>(id);

            if (footballClub != null)
            {
                footballClub.IsDeleted = true;

                await repo.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<FootballClubViewModel>> GetAllAsync()
        {
            var entities = await repo.AllReadonly<FootballClub>()
                .Where(f => f.IsDeleted == false).ToListAsync();

            return entities
                .Select(e => new FootballClubViewModel()
                {
                    Name = e.Name,
                    Nickname = e.Nickname,
                    Trophies = e.Trophies,
                    FoundedYear = e.FoundedYear,
                    LogoImageUrl = e.LogoImageUrl,
                    Address = e.Address,
                    City = e.City,
                    StadiumId = e.StadiumId,
                    LeagueId = e.LeagueId
                });
        }

        public async Task<IEnumerable<League>> GetLeaguesAsync()
        {
            return await repo.All<League>().ToListAsync(); 
        }

        public async Task<IEnumerable<Stadium>> GetStadiumsAsync()
        {
            return await repo.All<Stadium>().ToListAsync();
        }
    }
}
