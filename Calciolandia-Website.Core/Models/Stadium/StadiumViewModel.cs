using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models.Stadium
{
    public class StadiumViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MinLength(3)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string City { get; set; } = null!;
    }
}
