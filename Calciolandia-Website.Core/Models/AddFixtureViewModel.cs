using Calciolandia_Website.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models
{
    public class AddFixtureViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string Result { get; set; } = null!;

        public int Round { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Season { get; set; } = null!;

        public bool IsDeleted { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Time { get; set; }
        public int? HomeTeamId { get; set; }

        public IEnumerable<FootballClub> HomeTeams { get; set; } = new List<FootballClub>();

        public int? AwayTeamId { get; set; }

        public IEnumerable<FootballClub> AwayTeams { get; set; } = new List<FootballClub>();
        public int? StadiumId { get; set; }

        public IEnumerable<Stadium> Stadiums { get; set; } = new List<Stadium>();

        public int? LeagueId { get; set; }

        public IEnumerable<League> Leagues { get; set; } = new List<League>();
    }
}
