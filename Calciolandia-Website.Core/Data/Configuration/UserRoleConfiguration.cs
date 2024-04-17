using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Configuration
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(CreateUserRoles());
        }

        private List<IdentityUserRole<Guid>> CreateUserRoles()
        {
            var usersRoles = new List<IdentityUserRole<Guid>>();

            var firstRole = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse("469c79e1-d881-4c0b-952f-f08af274800d"),
                UserId = Guid.Parse("35e824bf-a9ff-4dfa-9cd7-e0bb181ee50a")
            };

            usersRoles.Add(firstRole);

            return usersRoles;
        }
    }
}
