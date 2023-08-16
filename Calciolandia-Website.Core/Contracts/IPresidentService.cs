using Calciolandia_Website.Core.Data.Models;
using Calciolandia_Website.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface IPresidentService
    {
        Task<IEnumerable<PresidentViewModel>> GetAllAsync();

        Task AddAsync(PresidentViewModel model);

        Task DeleteAsync(Guid id);

        Task<IEnumerable<FootballClub>> GetAllFootballClubsAsync();

        Task<PresidentViewModel> GetForEditAsync(Guid id);

        Task EditAsync(PresidentViewModel model);

        Task<PresidentInfoViewModel> GetPresidentById(Guid id);
    }
}
