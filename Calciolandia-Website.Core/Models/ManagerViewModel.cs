using Calciolandia_Website.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models
{
    public class ManagerViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        //[Required]
        //[StringLength(20, MinimumLength = 3)]
        //public string MiddleName { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nationality { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime ContractSignedDate { get; set; }

        [Required]
        public DateTime ContractExpiredDate { get; set; }

        public string? ImageUrl { get; set; }

        

        public int? FootballClubId { get; set; }

        public IEnumerable<FootballClub> FootballClubs { get; set; } = new List<FootballClub>();
    }
}
