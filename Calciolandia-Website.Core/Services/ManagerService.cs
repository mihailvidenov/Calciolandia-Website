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
    public class ManagerService : IManagerService
    {
        private readonly IRepository repo;

        public ManagerService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddAsync(ManagerViewModel model)
        {
            var manager = new Manager()
            {
                FirstName = model.FirstName,
                //MiddleName = model.MiddleName,
                LastName = model.LastName,
                Age = model.Age,
                Nationality = model.Nationality,
                BirthDate = model.BirthDate,
                //Salary = model.Salary,
                ContractSignedDate = model.ContractSignedDate,
                ContractExpiredDate = model.ContractExpiredDate,
                ImageUrl = model.ImageUrl,
                FootballClubId = model.FootballClubId
            };

            await repo.AddAsync(manager);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var manager = await repo.GetByIdAsync<Manager>(id);

            if (manager != null)
            {
                manager.IsDeleted = true;
                await repo.SaveChangesAsync();
            }
        }

        

        public async Task<IEnumerable<ManagerViewModel>> GetAllAsync()
        {
            var entities = await repo.AllReadonly<Manager>()
                .Where(m => m.IsDeleted == false)
                .ToListAsync();

            return entities.Select(m => new ManagerViewModel()
            {
                Id = m.Id,
                FirstName = m.FirstName,
                //MiddleName = m.MiddleName,
                LastName = m.LastName,
                Age = m.Age,
                Nationality =  m.Nationality,
                BirthDate = m.BirthDate,
                //Salary = m.Salary,
                ContractSignedDate = m.ContractSignedDate,
                ContractExpiredDate = m.ContractExpiredDate,
                ImageUrl = m.ImageUrl,
                FootballClubId = m.FootballClubId
            });
            
        }

        public async Task<IEnumerable<FootballClub>> GetFootballClubsAsync()
        {
            return await repo.All<FootballClub>()
                .Where(f => f.IsDeleted == false)
                .ToListAsync();
        }

        public async Task<ManagerViewModel> GetForEditAsync(Guid id)
        {
            var manager = await repo.GetByIdAsync<Manager>(id);

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
            var manager = await repo.GetByIdAsync<Manager>(model.Id);

            manager.FirstName = model.FirstName;
            manager.LastName = model.LastName;
            manager.Nationality = model.Nationality;
            manager.Age = model.Age;
            manager.BirthDate = model.BirthDate;
            manager.ContractSignedDate = model.ContractSignedDate;
            manager.ContractExpiredDate = model.ContractExpiredDate;
            manager.ImageUrl = model.ImageUrl;
            manager.FootballClubId = model.FootballClubId;

            await repo.SaveChangesAsync();
        }
    }
}
