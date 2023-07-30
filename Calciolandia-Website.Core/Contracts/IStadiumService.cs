using Calciolandia_Website.Core.Models.Stadium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Contracts
{
    public interface IStadiumService
    {
        Task<IEnumerable<StadiumViewModel>> GetAllAsync();

        Task AddAsync(StadiumViewModel model);

        Task DeleteAsync(int id);
    }
}
