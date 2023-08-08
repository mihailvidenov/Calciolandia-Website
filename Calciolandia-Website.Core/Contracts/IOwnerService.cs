using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface IOwnerService
    {
        Task<IEnumerable<OwnerViewModel>> GetAllAsync();

        Task AddAsync(OwnerViewModel model);

        Task DeleteAsync(Guid id);

        Task<IEnumerable<FootballClub>> GetAllFootballClubsAsync();
    }
}
