using Calciolandia_Website.Core.Contracts;
using Calciolandia_Website.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.UnitTests.UnitTests
{
    [TestFixture]
    public class LeagueServiceTests : UnitTestsBase
    {
        private ILeagueService leagueService;

        public void SetUp()
            => this.leagueService = new LeagueService(this.data);
    }
}
