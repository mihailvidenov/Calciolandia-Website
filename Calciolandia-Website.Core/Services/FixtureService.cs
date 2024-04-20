using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Services
{
    public class FixtureService : IFixtureService
    {
        public Task AddAsync(FixtureViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(FixtureViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FixtureViewModel>> GetAllByFootballClubAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FixtureViewModel>> GetAllByLeagueAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FixtureViewModel>> GetAllByRoundAsync(int round)
        {
            throw new NotImplementedException();
        }

        public Task<GetFixtureViewModel> GetFixtureAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<FixtureViewModel> GetForEditAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
