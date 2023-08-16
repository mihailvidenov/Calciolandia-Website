using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface IManagerService
    {
        Task<IEnumerable<ManagerViewModel>> GetAllAsync();

        Task AddAsync(ManagerViewModel model);

        Task DeleteAsync(Guid id);

        Task<IEnumerable<FootballClub>> GetFootballClubsAsync();

        Task<ManagerViewModel> GetForEditAsync(Guid id);

        Task EditAsync(ManagerViewModel model);

        Task<ManagerViewModel> GetManagerById(Guid id);

    }
}
