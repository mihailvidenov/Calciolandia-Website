using Calciolandia_Website.Core.Constants;
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
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<IdentityRole<Guid>> CreateRoles()
        {
            var roles = new List<IdentityRole<Guid>>();

            var admin = new IdentityRole<Guid>()
            {
                Id = Guid.Parse("469c79e1-d881-4c0b-952f-f08af274800d"),
                Name = RoleConstants.Admin,
                NormalizedName = RoleConstants.Admin.ToUpper()
            };

            roles.Add(admin);

            return roles;
        }
    }
}
