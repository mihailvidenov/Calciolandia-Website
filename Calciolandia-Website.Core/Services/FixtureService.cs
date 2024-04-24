using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data.Common;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Services
{
    public class FixtureService : IFixtureService
    {

        private readonly IRepository repo;

        public FixtureService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task AddAsync(AddFixtureViewModel model)
        {
            var fixture = new Fixture()
            {
                Id = model.Id,
                Result = model.Result,
                Round = model.Round,
                Season = model.Season,
                Date = model.Date,
                HomeTeamId = model.HomeTeamId,
                AwayTeamId = model.AwayTeamId,
                StadiumId = model.StadiumId,
                LeagueId = model.LeagueId
            };

            await repo.AddAsync(fixture);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var fixture = await repo.GetByIdAsync<Fixture>(id);

            if (fixture != null)
            {
                fixture.IsDeleted = true;

                await repo.SaveChangesAsync();
            }
        }

        public async Task EditAsync(AddFixtureViewModel model)
        {
            var fixture = await repo.GetByIdAsync<Fixture>(model.Id);

            fixture.Result = model.Result;
            fixture.Season = model.Season;
            fixture.Round = model.Round;
            fixture.Date = model.Date;
            fixture.HomeTeamId = model.HomeTeamId;
            fixture.AwayTeamId = model.AwayTeamId;
            fixture.StadiumId = model.StadiumId;
            fixture.LeagueId = model.LeagueId;

            await repo.SaveChangesAsync();
        }


        public async Task<IEnumerable<GetFixtureViewModel>> GetAllFixturesByLeague(int id)
        {
            var entities =  await repo.AllReadonly<Fixture>()
                 .Where(f => f.IsDeleted == false && f.LeagueId == id)
                 .ToListAsync();

        //    return  entities
        //      .Select(e => new GetFixtureViewModel()
        //      {
        //          Id = e.Id,
        //          Result = e.Result,
        //          Season = e.Season,
        //          Date = e.Date.ToString("dd/MM/yyyy",
        //          CultureInfo.InvariantCulture),
        //          Time = e.Time,
        //          HomeTeamId = e.HomeTeamId,
        //          AwayTeamid = e.AwayTeamId,
        //          StadiumId = e.StadiumId,
        //          LeagueId = e.LeagueId,
        //           HomeTeam = await repo.GetByIdAsync<FootballClub>(e.HomeTeamId),
        //    AwayTeam = await repo.GetByIdAsync<FootballClub>(e.AwayTeamid),
        //   Stadium = await repo.GetByIdAsync<Stadium>(e.StadiumId),
        //    League = await repo.GetByIdAsync<League>(e.LeagueId),
        //});

            var fixtures = new List<GetFixtureViewModel>();

            foreach (var entity in entities)
            {
                var fixture = new GetFixtureViewModel()
                {
                    Id = entity.Id,
                    Result = entity.Result,
                    Season = entity.Season,
                    Date = entity.Date.ToString("dd/MM/yyyy",
                  CultureInfo.InvariantCulture),
                    Time = entity.Time,
                    HomeTeamId = entity.HomeTeamId,
                    AwayTeamid = entity.AwayTeamId,
                    StadiumId = entity.StadiumId,
                    LeagueId = entity.LeagueId
                };

                fixture.HomeTeam = await repo.GetByIdAsync<FootballClub>(entity.HomeTeamId);
                fixture.AwayTeam = await repo.GetByIdAsync<FootballClub>(entity.AwayTeamId);
                fixture.Stadium = await repo.GetByIdAsync<Stadium>(entity.Stadium);
                fixture.League = await repo.GetByIdAsync<League>(entity.League);

                fixtures.Add(fixture);
            }

            return fixtures;

        

        }

        public async Task<IEnumerable<FixtureViewModel>> GetAllFixturesByRound(int round)
        {
            var entities =  await repo.AllReadonly<FixtureViewModel>()
                .Where(f => f.IsDeleted == false && f.Round == round)
                .ToListAsync();

            return entities
                .Select(e => new FixtureViewModel()
                {
                    Id = e.Id,
                    Result = e.Result,
                    Season = e.Season,
                    Date = e.Date,
                    Time = e.Time,
                    HomeTeamId = e.HomeTeamId,
                    AwayTeamId = e.AwayTeamId,
                    StadiumId = e.StadiumId,
                    LeagueId = e.LeagueId
                });


        }

        public async Task<GetFixtureViewModel> GetFixtureAsync(Guid id)
        {
            var fixture = await repo.GetByIdAsync<Fixture>(id);

            var model = new GetFixtureViewModel()
            {
                Result = fixture.Result,
                Round = fixture.Round,
                Season = fixture.Season,
                Date = fixture.Date.ToString("dd/MM/yyyy",
                  CultureInfo.InvariantCulture),
                Time = fixture.Time,
                HomeTeamId = fixture.HomeTeamId,
                AwayTeamid = fixture.AwayTeamId,
                StadiumId = fixture.StadiumId,
                LeagueId = fixture.LeagueId
            };

            model.HomeTeam = await repo.GetByIdAsync<FootballClub>(model.HomeTeamId);
            model.AwayTeam = await repo.GetByIdAsync<FootballClub>(model.AwayTeamid);
            model.Stadium = await repo.GetByIdAsync<Stadium>(model.StadiumId);
            model.League = await repo.GetByIdAsync<League>(model.LeagueId);

            return model;

        }

        public async Task<IEnumerable<FootballClub>> GetFootballClubsAsync()
        {
            return await repo.All<FootballClub>().Where(s => s.IsDeleted == false).ToListAsync();
        }

        public async Task<AddFixtureViewModel> GetForEditAsync(Guid id)
        {
            var fixture = await repo.GetByIdAsync<Fixture>(id);

            var model = new AddFixtureViewModel()
            {
                Id = fixture.Id,
                Result = fixture.Result,
                Season = fixture.Season,
                Round = fixture.Round,
                Date = fixture.Date,
                HomeTeamId = fixture.HomeTeamId,
                AwayTeamId = fixture.AwayTeamId,
                StadiumId = fixture.StadiumId,
                LeagueId = fixture.LeagueId
            };

            return model;
        }

        public async Task<IEnumerable<League>> GetLeaguesAsync()
        {
            return await repo.All<League>().Where(s => s.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<Stadium>> GetStadiumsAsync()
        {
            return await repo.All<Stadium>().Where(s => s.IsDeleted == false).ToListAsync();
        }
    }
}
