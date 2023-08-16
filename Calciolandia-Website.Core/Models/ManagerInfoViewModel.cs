using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models
{
    public class ManagerInfoViewModel
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
        public string BirthDate { get; set; }

        [Required]
        public string ContractSignedDate { get; set; }

        [Required]
        public string ContractExpiredDate { get; set; }

        public string? ImageUrl { get; set; }
    }
}
