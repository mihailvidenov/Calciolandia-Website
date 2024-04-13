using Calciolandia_Website.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
           var users = new List<ApplicationUser>();
           var hasher = new PasswordHasher<ApplicationUser>();

            var adminUser = new ApplicationUser()
            {
                FirstName = "Mihail",
                LastName = "Videnov",
                FootballClubId = 5,
                UserName = "mishaka002",
                NormalizedUserName = "mishaka002",
                Email = "m_fvidenov@abv.bg",
                NormalizedEmail = "m_fvidenov@abv.bg"
            };

            adminUser.PasswordHash =
                hasher.HashPassword(adminUser, "misho123");

            users.Add(adminUser);

            var user = new ApplicationUser()
            {
                FirstName = "Luben",
                LastName = "Videnov",
                FootballClubId = 7,
                UserName = "luben_v",
                NormalizedUserName = "luben_v",
                Email = "luben_6@abv.bg",
                NormalizedEmail = "luben_6@abv.bg"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "luben123");

            users.Add(user);

            return users;

        }
    }
}
