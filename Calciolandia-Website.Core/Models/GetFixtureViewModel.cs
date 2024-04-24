using Calciolandia_Website.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models
{
    public class GetFixtureViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(10, MinimumLength = 1)]
        public string Result { get; set; } = null!;

        public int Round { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Season { get; set; } = null!;

        [Required]
        public string Date { get; set; } = null!;

        [Required]
        public string Time { get; set; } = null!;

        public bool IsDeleted { get; set; }


        public int? HomeTeamId { get; set; }

        public FootballClub HomeTeam { get; set; } = null!;
        public int? AwayTeamid { get; set; }

        public FootballClub AwayTeam { get; set; } = null!;
        public int? StadiumId { get; set; }

        public Stadium Stadium { get; set; } = null!;
        public int? LeagueId { get; set; }

        public League League { get; set; } = null!;
    }
}
