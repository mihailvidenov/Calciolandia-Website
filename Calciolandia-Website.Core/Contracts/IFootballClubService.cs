using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface IFootballClubService
    {
        Task<IEnumerable<FootballClubViewModel>> GetAllAsync(int id);

        Task AddAsync(FootballClubViewModel model);

        Task DeleteAsync(int id);

        Task<IEnumerable<Stadium>> GetStadiumsAsync();

        Task<IEnumerable<League>> GetLeaguesAsync();

        Task<FootballClubViewModel> GetForEditAsync(int id);

        Task EditAsync(FootballClubViewModel model);

        Task<GetFootballClubViewModel> GetFootballClubAsync(int id);

        Task<IEnumerable<Player>> GetPlayersByFootballClub(int id);

        Task<IEnumerable<Fixture>> GetFixturesByFootballClub(int id);

        Task<IEnumerable<Manager>> GetManagersByFootballClub(int id);

        Task<IEnumerable<President>> GetPresidentByFootballClub(int id);

        Task<IEnumerable<Stadium>> GetStadiumById(int id);
    }
}
