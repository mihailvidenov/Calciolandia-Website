using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Data;
using Calciolandia_Website.Core.Data.Common;
using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calciolandia_Website.Core.Services
{
    public class StadiumService : IStadiumService
    {

        
        private readonly ApplicationDbContext dbContext;

        public StadiumService(ApplicationDbContext _dbContext)
        {
           
            dbContext = _dbContext;
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

            await dbContext.Stadiums.AddAsync(stadium);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var stadium = await dbContext.Stadiums.FindAsync(id);

            if (stadium != null)
            {
                stadium.IsDeleted = true;

                await dbContext.SaveChangesAsync();
            }


         
        }


        public async Task<IEnumerable<StadiumViewModel>> GetAllAsync()
        {
            var entities = await dbContext.Stadiums
                .Where(s => s.IsDeleted == false)
                .AsNoTracking()
                .ToListAsync();

            return entities.Select(s => new StadiumViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                Capacity = s.Capacity,
                ImageUrl = s.ImageUrl,
                Address = s.Address,
                City = s.City
            });
        }

        public async Task<StadiumViewModel> GetForEditAsync(int id)
        {
            var stadium = await dbContext.Stadiums.FindAsync(id);

            var model = new StadiumViewModel()
            {
                Id = stadium.Id,
                Name = stadium.Name,
                Capacity = stadium.Capacity,
                ImageUrl = stadium.ImageUrl,
                Address = stadium.Address,
                City = stadium.City
            };

            return model;
        }

        public async Task EditAsync(StadiumViewModel model)
        {
            var stadium = await dbContext.Stadiums.FindAsync(model.Id);

            stadium.Name = model.Name;
            stadium.Capacity = model.Capacity;
            stadium.ImageUrl = model.ImageUrl;
            stadium.Address = model.Address;
            stadium.City = model.City;

            await dbContext.SaveChangesAsync();
        }

        public async Task<StadiumViewModel> GetStadiumById(int id)
        {
            var stadium = await dbContext.Stadiums.FindAsync(id);

            var model = new StadiumViewModel()
            {
                Name = stadium.Name,
                Capacity = stadium.Capacity,
                ImageUrl = stadium.ImageUrl,
                Address = stadium.Address,
                City = stadium.City
            };

            return model;
        }
    }
}
