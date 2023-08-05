using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calciolandia_Website.Core.Data.Models;

namespace Calciolandia_Website.Core.Models
{
    public class FootballClubViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nickname { get; set; } = null!;

        [Required]
        public int Trophies { get; set; }

        [Required]
        public string LogoImageUrl { get; set; } = null!;

        
        public int? FoundedYear { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string City { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        public int? LeagueId { get; set; }

        public IEnumerable<League> Leagues { get; set; } = new List<League>();

        public int? StadiumId { get; set; }

        public IEnumerable<Stadium> Stadiums { get; set; } = new List<Stadium>();
    }
}
