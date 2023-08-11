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
    public class PlayerService : IPlayerService
    {

        private readonly IRepository repo;

        public PlayerService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task AddAsync(PlayerViewModel model)
        {
            var player = new Player()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Nationality = model.Nationality,
                Position = model.Position,
                BirthDate = model.BirthDate,
                ContractSignedDate = model.ContractSignedDate,
                ContractExpiredDate = model.ContractExpiredDate,
                FootballClubId = model.FootballClubId,
                ImageUrl = model.ImageUrl,
                MarketValue = model.MarketValue

            };

            await repo.AddAsync(player);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var player = await repo.GetByIdAsync<Player>(id);

            if (player != null)
            {
                player.IsDeleted = true;

                await repo.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<PlayerViewModel>> GetAllAsync()
        {
            var entities = await repo.AllReadonly<Player>()
                .Where(p => p.IsDeleted == false)
                .ToListAsync();

            return entities.Select(e => new PlayerViewModel()
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Age = e.Age,
                Nationality = e.Nationality,
                Position = e.Position,
                BirthDate = e.BirthDate,
                ContractSignedDate = e.ContractSignedDate,
                ContractExpiredDate = e.ContractExpiredDate,
                ImageUrl = e.ImageUrl,
                MarketValue = e.MarketValue,
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
