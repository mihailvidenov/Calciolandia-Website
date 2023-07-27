using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string LastName { get; set; } = null!;

    }
}
