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
                Id = Guid.Parse("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a"),
                FirstName = "Mihail",
                LastName = "Videnov",
                FootballClubId = 5,
                UserName = "mishaka002",
                NormalizedUserName = "mishaka002",
                Email = "m_fvidenov@abv.bg",
                NormalizedEmail = "m_fvidenov@abv.bg",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
               
            };

            

            adminUser.PasswordHash =
                hasher.HashPassword(adminUser, "misho123");

            users.Add(adminUser);

            var user = new ApplicationUser()
            {
                Id = Guid.Parse("37390eb1-f3f7-45ee-835f-9712488e3aa5"),
                FirstName = "Luben",
                LastName = "Videnov",
                FootballClubId = 7,
                UserName = "luben_v",
                NormalizedUserName = "luben_v",
                Email = "luben_6@abv.bg",
                NormalizedEmail = "luben_6@abv.bg",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            user.PasswordHash =
                hasher.HashPassword(user, "luben123");

            users.Add(user);


           

            return users;

        }
    }
}
