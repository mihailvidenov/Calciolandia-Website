using Calciolandia_Website.Core.Models.League;
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

        //Task EditAsync(LeagueViewModel model);

        Task DeleteAsync(int id);

        //Task<LeagueViewModel> GetByIdAsync(int id);
    }
}
