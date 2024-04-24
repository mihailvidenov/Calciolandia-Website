using Calciolandia_Website.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Configuration
{
    internal class FixtureConfiguration : IEntityTypeConfiguration<Fixture>
    {
        public void Configure(EntityTypeBuilder<Fixture> builder)
        {
            builder.HasData(CreateFixtures());
        }

        private List<Fixture> CreateFixtures()
        {
            var fixtures = new List<Fixture>();


            var fixture1 = new Fixture()
            {
                Id = Guid.NewGuid(),
                Season = "2023/2024",
                Round = 33,
                Result = "0 - 1",
                Date = DateTime.ParseExact("2024-04-19", "yyyy-MM-dd",
                  CultureInfo.InvariantCulture),
                Time = "19:30",
                HomeTeamId = 7,
                AwayTeamId = 11,
                StadiumId = 9,
                LeagueId = 1
            };

            fixtures.Add(fixture1);

            var fixture2 = new Fixture()
            {
                Id = Guid.NewGuid(),
                Season = "2023/2024",
                Round = 33,
                Result = "2 - 2",
                Date = DateTime.ParseExact("2024-04-19", "yyyy-MM-dd",
                  CultureInfo.InvariantCulture),
                Time = "21:45",
                HomeTeamId = 3,
                AwayTeamId = 10,
                StadiumId = 5,
                LeagueId = 1
            };

            fixtures.Add(fixture2);

            return fixtures;
        }
    }
}
