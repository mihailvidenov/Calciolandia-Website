using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Models
{
    public class FootballClub
    {
        public FootballClub()
        {
            this.Players = new List<Player>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Nickname { get; set; } = null!;

        [Required]
        public int Trophies { get; set; }

        [Required]
        public string LogoImageUrl { get; set; } = null!;

        [Required]
        public DateTime FoundedYear { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public int LeagueId { get; set; }

        [ForeignKey(nameof(LeagueId))]
        public League League { get; set; } = null!;

        [Required]
        public Guid OwnerId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public Owner Owner { get; set; } = null!;

        [Required]
        public Guid ManagerId { get; set; }

        [ForeignKey(nameof(ManagerId))]
        public Manager Manager { get; set; } = null!;

        [Required]
        public int StadiumId { get; set; }

        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; } = null!;

        public List<Player> Players { get; set; } = null!;
    }
}
