using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface IFixtureService
    {
        Task<IEnumerable<FixtureViewModel>> GetAllByLeagueAsync(int id);

        Task<IEnumerable<FixtureViewModel>> GetAllByRoundAsync(int round);

        Task<IEnumerable<FixtureViewModel>> GetAllByFootballClubAsync(int id);

        Task DeleteAsync(Guid id);

        Task AddAsync(FixtureViewModel model);

        Task<FixtureViewModel> GetForEditAsync(Guid id);

        Task EditAsync(FixtureViewModel model);

        Task<GetFixtureViewModel> GetFixtureAsync(Guid id);
    }
}
