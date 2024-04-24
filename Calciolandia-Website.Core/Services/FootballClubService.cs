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

       

        public async Task<IEnumerable<FootballClubViewModel>> GetAllAsync(int id)
        {
            var entities = await repo.AllReadonly<FootballClub>()
                .Where(f => f.IsDeleted == false && f.LeagueId == id).ToListAsync();

            return entities
                .Select(e => new FootballClubViewModel()
                {
                    Id = e.Id,
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

        public async Task<FootballClubViewModel> GetForEditAsync(int id)
        {
            var footballClub = await repo.GetByIdAsync<FootballClub>(id);

            var model = new FootballClubViewModel()
            {
                Id = footballClub.Id,
                Name = footballClub.Name,
                Nickname = footballClub.Nickname,
                Trophies = footballClub.Trophies,
                LogoImageUrl = footballClub.LogoImageUrl,
                FoundedYear = footballClub.FoundedYear,
                City = footballClub.City,
                Address = footballClub.Address,
                LeagueId = footballClub.LeagueId,
                StadiumId = footballClub.StadiumId

            };

            return model;
        }

        public async Task EditAsync(FootballClubViewModel model)
        {
            var footballClub = await repo.GetByIdAsync<FootballClub>(model.Id);

            footballClub.Name = model.Name;
            footballClub.Nickname = model.Nickname;
            footballClub.Trophies = model.Trophies;
            footballClub.LogoImageUrl = model.LogoImageUrl;
            footballClub.FoundedYear = model.FoundedYear;
            footballClub.Address = model.Address;
            footballClub.City = model.City;
            footballClub.LeagueId = model.LeagueId;
            footballClub.StadiumId = model.StadiumId;

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<League>> GetLeaguesAsync()
        {
            return await repo.All<League>().ToListAsync(); 
        }

        public async Task<IEnumerable<Stadium>> GetStadiumsAsync()
        {
            return await repo.All<Stadium>().ToListAsync();
        }

        public async Task<GetFootballClubViewModel> GetFootballClubAsync(int id)
        {
            var footballClub = await repo.GetByIdAsync<FootballClub>(id);

            var model = new GetFootballClubViewModel()
            { 
                
                Name = footballClub.Name,
                Nickname = footballClub.Nickname,
                LogoImageUrl = footballClub.LogoImageUrl,
                FoundedYear = footballClub.FoundedYear,
                Trophies = footballClub.Trophies,
                Address = footballClub.Address,
                City = footballClub.City,
               
            };

            return model;

        }

        public async Task<IEnumerable<Player>> GetPlayersByFootballClub(int id)
        {
            return await repo.AllReadonly<Player>()
                .Where(p => p.IsDeleted == false && p.FootballClubId == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Manager>> GetManagersByFootballClub(int id)
        {
            return await repo.AllReadonly<Manager>()
                .Where(m => m.IsDeleted == false && m.FootballClubId == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<President>> GetPresidentByFootballClub(int id)
        {
            return await repo.AllReadonly<President>()
                .Where(p => p.IsDeleted == false && p.FootballClubId == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Stadium>> GetStadiumById(int id)
        {
            return await repo.AllReadonly<Stadium>()
                .Where(s => s.IsDeleted == false && s.FootballClubs.Any((fc => fc.Id == id)))
                .ToListAsync();
        }

        public async Task<IEnumerable<Fixture>> GetFixturesByFootballClub(int id)
        {
            return await repo.AllReadonly<Fixture>()
                .Where(f => f.IsDeleted == false && (f.HomeTeamId == id || f.AwayTeamId == id)).ToListAsync();


        }
    } 
}
