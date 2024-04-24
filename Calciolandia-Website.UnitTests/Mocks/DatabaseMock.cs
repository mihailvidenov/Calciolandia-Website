using Calciolandia_Website.Core.Data;
using Calciolandia_Website.Core.Data.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.UnitTests.Mocks
{
    public static class DatabaseMock
    {
        public static ApplicationDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("ApplicationDbInMemory"
                    + DateTime.Now.Ticks.ToString())
                    .Options;

                return new ApplicationDbContext(dbContextOptions, false);
            }
        }
    }
}
