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
       


        Task DeleteAsync(Guid id);

        Task AddAsync(AddFixtureViewModel model);

        Task<AddFixtureViewModel> GetForEditAsync(Guid id);

        Task EditAsync(AddFixtureViewModel model);

        Task<GetFixtureViewModel> GetFixtureAsync(Guid id);

        Task<IEnumerable<FixtureViewModel>> GetAllFixturesByRound(int round);

        Task<IEnumerable<GetFixtureViewModel>> GetAllFixturesByLeague(int id);


        Task<IEnumerable<Stadium>> GetStadiumsAsync();

        Task<IEnumerable<League>> GetLeaguesAsync();

        Task<IEnumerable<FootballClub>> GetFootballClubsAsync();


    }
}
