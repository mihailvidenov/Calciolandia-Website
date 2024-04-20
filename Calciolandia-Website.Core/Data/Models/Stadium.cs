using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Models
{
    public class Stadium
    {
        public Stadium()
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
        public int Capacity { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string City { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public List<FootballClub> FootballClubs { get; set; } = null!;

        public List<Fixture> Fixtures { get; set; } = null!;
    }
}
