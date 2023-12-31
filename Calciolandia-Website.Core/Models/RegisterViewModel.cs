﻿using Calciolandia_Website.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models
{
    public class RegisterViewModel
    {

		[Required]
		[EmailAddress]
		public string Email { get; set; } = null!;

		[Required]
		[StringLength(20, MinimumLength = 2)]
		public string UserName { get; set; } = null!;

		[Required]
		[Compare(nameof(PasswordRepeat))]
		[DataType(DataType.Password)]
		public string Password { get; set; } = null!;

		[Required]
		[DataType(DataType.Password)]
		public string PasswordRepeat { get; set; } = null!;

		[Required]
		[StringLength(20, MinimumLength = 2)]
		public string FirstName { get; set; } = null!;

		[Required]
		[StringLength(20, MinimumLength = 2)]
		public string LastName { get; set; } = null!;

		public int? FootballClubId { get; set; }

		public IEnumerable<FootballClub> FootballClubs { get; set; } = new List<FootballClub>();
	}
}
