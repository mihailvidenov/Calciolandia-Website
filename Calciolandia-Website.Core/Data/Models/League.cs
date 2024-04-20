using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Models
{
    public class League
    {
        public League()
        {
            this.FootballClubs = new List<FootballClub>();
            this.Fixtures = new List<Fixture>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Country { get; set; } = null!;

        [Required]
        public string LogoImageUrl { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public List<FootballClub> FootballClubs { get; set; } = null!;

        public List<Fixture> Fixtures { get; set; } = null!;
    }
}
