using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models

{
    public class LeagueViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Country { get; set; } = null!;

        [Required]
        public string LogoImageUrl { get; set; } = null!;
    }
}
