using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Data.Models
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        //[Required]
        //[StringLength(20)]
        //public string MiddleName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Nationality { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        public int? Number { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime ContractSignedDate { get; set; }

        [Required]
        public DateTime ContractExpiredDate { get; set; }

        //[Required]
        //public decimal Salary { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string MarketValue { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public int? FootballClubId { get; set; }

        [ForeignKey(nameof(FootballClubId))]
        public FootballClub FootballClub { get; set; } 
    }
}
