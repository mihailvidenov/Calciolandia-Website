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
    internal class PresidentConfiguration : IEntityTypeConfiguration<President>
    {
        public void Configure(EntityTypeBuilder<President> builder)
        {
            throw new NotImplementedException();
        }
    }
}
