using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calciolandia_Website.Core.Data.Models
{
    public class Fixture

    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(10)]
        public string Result { get; set; } = null!;

        public int Round { get; set; }

        [StringLength(20)]
        public string Season { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Time { get; set; }

        public bool IsDeleted { get; set; }
        public int? HomeTeamId { get; set; }

        [ForeignKey(nameof(HomeTeamId))]
        public FootballClub HomeTeam { get; set; } = null!;

        public int? AwayTeamId { get; set; }

        [ForeignKey(nameof(AwayTeamId))]
        public FootballClub AwayTeam { get; set; } = null!;


        public int? StadiumId { get; set; }

        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; } = null!;

        public int? LeagueId { get; set; }

        [ForeignKey(nameof(LeagueId))]
        public League League { get; set; } = null!;

    }
}
