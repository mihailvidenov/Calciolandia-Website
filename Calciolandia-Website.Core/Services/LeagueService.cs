using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data;
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
        private readonly ApplicationDbContext dbContext;

        public LeagueService(ApplicationDbContext _dbContext)
        {
            
            dbContext = _dbContext;
        }

        public async Task AddAsync(LeagueViewModel model)
        {
            var league = new League()
            {
                Name = model.Name,
                Country = model.Country,
                LogoImageUrl = model.LogoImageUrl
            };

            await dbContext.Leagues.AddAsync(league);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var league = await dbContext.Leagues.FindAsync(id);

            if (league != null)
            {
                league.IsDeleted = true;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task EditAsync(LeagueViewModel model)
        {
            var league = await dbContext.Leagues.FindAsync(model.Id);
            
            league.Name = model.Name;
            league.Country = model.Country;
            league.LogoImageUrl = model.LogoImageUrl;

            await dbContext.SaveChangesAsync();

        }

        
        public async Task<IEnumerable<LeagueViewModel>> GetAllAsync()
        {
            var entities = await dbContext.Leagues
                .Where(l => l.IsDeleted == false)
                .AsNoTracking().ToListAsync();

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
            var league = await dbContext.Leagues.FindAsync(id);

            var model = new LeagueViewModel()
            {
                Id = league.Id,
                Name = league.Name,
                Country = league.Country,
                LogoImageUrl = league.LogoImageUrl
            };

            return model;

        }

      
    }
}
