using Calciolandia_Website.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Configuration
{
    internal class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasData(CreateLeagues());
        }


        private List<League> CreateLeagues()
        {
            var leagues = new List<League>();

            var serieA = new League()
            {
                Id = 1,
                Name = "Serie A",
                Country = "Italy",
                LogoImageUrl = "https://tmssl.akamaized.net/images/logo/header/it1.png?lm=1656073460"
            };

            leagues.Add(serieA);

            var serieB = new League()
            {
                Id = 2,
                Name = "Serie B",
                Country = "Italy",
                LogoImageUrl = "https://tmssl.akamaized.net/images/logo/header/it2.png?lm=1548242827"
            };


            leagues.Add(serieB);

            var serieC = new League()
            {
                Id = 3,
                Name = "Serie C",
                Country = "Italy",
                LogoImageUrl = "https://tmssl.akamaized.net/images/logo/header/it3a.png?lm=1599832650"
            };


            leagues.Add(serieC);


            return leagues;
        }
    }
}
