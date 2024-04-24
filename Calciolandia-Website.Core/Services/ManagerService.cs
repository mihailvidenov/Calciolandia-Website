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
    public class ManagerService : IManagerService
    {
        
        private readonly ApplicationDbContext dbContext;

        public ManagerService( ApplicationDbContext _dbContext)
        {
           
            dbContext = _dbContext;
        }

        public async Task AddAsync(ManagerViewModel model)
        {
            var manager = new Manager()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Nationality = model.Nationality,
                BirthDate = model.BirthDate,
                ContractSignedDate = model.ContractSignedDate,
                ContractExpiredDate = model.ContractExpiredDate,
                ImageUrl = model.ImageUrl,
                FootballClubId = model.FootballClubId
            };

            await dbContext.Managers.AddAsync(manager);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var manager = await dbContext.Managers.FindAsync(id);

            if (manager != null)
            {
                manager.IsDeleted = true;
                await dbContext.SaveChangesAsync();
            }
        }

        

        public async Task<IEnumerable<ManagerViewModel>> GetAllAsync()
        {
            var entities = await dbContext.Managers
                .Where(m => m.IsDeleted == false)
                .AsNoTracking()
                .ToListAsync();

            return entities.Select(m => new ManagerViewModel()
            {
                Id = m.Id,
                FirstName = m.FirstName,
                LastName = m.LastName,
                Age = m.Age,
                Nationality =  m.Nationality,
                BirthDate = m.BirthDate,
                ContractSignedDate = m.ContractSignedDate,
                ContractExpiredDate = m.ContractExpiredDate,
                ImageUrl = m.ImageUrl,
                FootballClubId = m.FootballClubId
            });
            
        }

        public async Task<IEnumerable<FootballClub>> GetFootballClubsAsync()
        {
            return await dbContext.FootballClubs
                .Where(f => f.IsDeleted == false)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ManagerViewModel> GetForEditAsync(Guid id)
        {
            var manager = await dbContext.Managers.FindAsync(id);

            var model = new ManagerViewModel()
            {
                Id = manager.Id,
                FirstName = manager.FirstName,
                LastName = manager.LastName,
                Nationality = manager.Nationality,
                Age = manager.Age,
                BirthDate = manager.BirthDate,
                ContractSignedDate = manager.ContractSignedDate,
                ContractExpiredDate = manager.ContractExpiredDate,
                ImageUrl = manager.ImageUrl,
                FootballClubId = manager.FootballClubId
            };

            return model;
        }

        public async Task EditAsync(ManagerViewModel model)
        {
            var manager = await dbContext.Managers.FindAsync(model.Id);

            manager.FirstName = model.FirstName;
            manager.LastName = model.LastName;
            manager.Nationality = model.Nationality;
            manager.Age = model.Age;
            manager.BirthDate = model.BirthDate;
            manager.ContractSignedDate = model.ContractSignedDate;
            manager.ContractExpiredDate = model.ContractExpiredDate;
            manager.ImageUrl = model.ImageUrl;
            manager.FootballClubId = model.FootballClubId;

            await dbContext.SaveChangesAsync();
        }

        public async Task<ManagerInfoViewModel> GetManagerById(Guid id)
        {
            var manager = await dbContext.Managers.FindAsync(id);

            var model = new ManagerInfoViewModel()
            { 
                FirstName = manager.FirstName,
                LastName = manager.LastName,
                Nationality = manager.Nationality,
                Age = manager.Age,
                BirthDate = manager.BirthDate.ToString("dd/MM/yyyy",
                  CultureInfo.InvariantCulture),
                ContractSignedDate = manager.ContractSignedDate.ToString("dd/MM/yyyy",
                  CultureInfo.InvariantCulture),
                ContractExpiredDate = manager.ContractExpiredDate.ToString("dd/MM/yyyy",
                  CultureInfo.InvariantCulture),
                ImageUrl = manager.ImageUrl
            };

            return model;

        }
    }
}
