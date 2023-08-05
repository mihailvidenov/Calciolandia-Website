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
    public class StadiumService : IStadiumService
    {

        private readonly IRepository repo;

        public StadiumService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task AddAsync(StadiumViewModel model)
        {
            var stadium = new Stadium()
            {
                Name = model.Name,
                Capacity = model.Capacity,
                ImageUrl = model.ImageUrl,
                Address = model.Address,
                City = model.City
            };

            await repo.AddAsync(stadium);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var stadium = await repo.GetByIdAsync<Stadium>(id);

            if (stadium != null)
            {
                stadium.IsDeleted = true;

                await repo.SaveChangesAsync();
            }


         
        }

        public async Task<IEnumerable<StadiumViewModel>> GetAllAsync()
        {
            var entities = await repo.AllReadonly<Stadium>()
                .Where(s => s.IsDeleted == false).ToListAsync();

            return entities.Select(s => new StadiumViewModel()
            {
                Name = s.Name,
                Capacity = s.Capacity,
                ImageUrl = s.ImageUrl,
                Address = s.Address,
                City = s.City
            });
        }
    }
}
