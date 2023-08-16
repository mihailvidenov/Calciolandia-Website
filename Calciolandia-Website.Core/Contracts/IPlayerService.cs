using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerViewModel>> GetAllAsync();

        Task AddAsync(PlayerViewModel model);

        Task DeleteAsync(Guid id);

        Task<IEnumerable<FootballClub>> GetAllFootballClubsAsync();

        Task<PlayerViewModel> GetForEditAsync(Guid id);

        Task EditAsync(PlayerViewModel model);

        Task<PlayerInfoViewModel> GetPlayerById(Guid id);
    } 
}
