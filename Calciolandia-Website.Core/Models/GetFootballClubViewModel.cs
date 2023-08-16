using Calciolandia_Website.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models
{
    public class GetFootballClubViewModel
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

        

        public int? StadiumId { get; set; }

        public Stadium Stadium { get; set; }

        public IEnumerable<Player> Players { get; set; } = new List<Player>();


        public IEnumerable<Manager> Managers { get; set; } = new List<Manager>();


        public IEnumerable<President> Presidents { get; set; } = new List<President>();
    }
}
