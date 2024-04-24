using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface ILeagueService
    {
        Task<IEnumerable<LeagueViewModel>> GetAllAsync();

        Task AddAsync(LeagueViewModel model);

        Task<LeagueViewModel> GetForEditAsync(int id);

        Task EditAsync(LeagueViewModel model);

        Task DeleteAsync(int id);
    }
}
