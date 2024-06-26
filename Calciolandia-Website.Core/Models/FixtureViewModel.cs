﻿using Calciolandia_Website.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciolandia_Website.Core.Models
{
    public class FixtureViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string Result { get; set; } = null!;

        public int Round { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Season { get; set; } = null!;

        public bool IsDeleted { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Time { get; set; }
        public int? HomeTeamId { get; set; }

        public FootballClub HomeTeams { get; set; } 

        public int? AwayTeamId { get; set; }

        public FootballClub AwayTeams { get; set; }
        public int? StadiumId { get; set; }

        public Stadium Stadium { get; set; } 

        public int? LeagueId { get; set; }

        public League Leagues { get; set; } 
    }
}
