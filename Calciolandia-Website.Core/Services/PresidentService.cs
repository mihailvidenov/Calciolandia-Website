using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data;
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
    public class PresidentService : IPresidentService
    {
        
        private readonly ApplicationDbContext dbContext;

        public PresidentService(ApplicationDbContext _dbContext)
        {
            
            dbContext = _dbContext;
        }

        public async Task AddAsync(PresidentViewModel model)
        {
            var owner = new President()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Nationality = model.Nationality,
                BirthDate = model.BirthDate,
                ImageUrl = model.ImageUrl,
                FootballClubId = model.FootballClubId
            };

            await dbContext.Presidents.AddAsync(owner);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var owner = await dbContext.Presidents.FindAsync(id);

            if (owner != null)
            {
                owner.IsDeleted = true;
                await dbContext.SaveChangesAsync();
            }
        }



        public async Task<IEnumerable<PresidentViewModel>> GetAllAsync()
        {
            var entities = await dbContext.Presidents
                .Where(o => o.IsDeleted == false)
                .AsNoTracking()
                .ToListAsync();

            return entities.Select(e => new PresidentViewModel()
            {
                Id = e.Id,
                FirstName = e.FirstName,
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
            return await dbContext.FootballClubs
                .Where(f => f.IsDeleted == false)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<PresidentViewModel> GetForEditAsync(Guid id)
        {
            var president = await dbContext.Presidents.FindAsync(id);

            var model = new PresidentViewModel()
            {
                Id = president.Id,
                FirstName = president.FirstName,
                LastName = president.LastName,
                Nationality = president.Nationality,
                Age = president.Age,
                BirthDate = president.BirthDate,
                ImageUrl = president.ImageUrl,
                FootballClubId = president.FootballClubId
            };

            return model;
        }

        public async Task EditAsync(PresidentViewModel model)
        {
            var president = await dbContext.Presidents.FindAsync(model.Id);

            president.FirstName = model.FirstName;
            president.LastName = model.LastName;
            president.Nationality = model.Nationality;
            president.Age = model.Age;
            president.BirthDate = model.BirthDate;
            president.ImageUrl = model.ImageUrl;
            president.FootballClubId = model.FootballClubId;

            await dbContext.SaveChangesAsync();
        }

        public async Task<PresidentInfoViewModel> GetPresidentById(Guid id)
        {
            var president = await dbContext.Presidents.FindAsync(id);

            var model = new PresidentInfoViewModel()
            {
                FirstName = president.FirstName,
                LastName = president.LastName,
                Nationality = president.Nationality,
                Age = president.Age,
                BirthDate = president.BirthDate.ToString("dd/MM/yyyy",
                  CultureInfo.InvariantCulture),
                ImageUrl = president.ImageUrl
            };

            return model;
        }
    }
}
