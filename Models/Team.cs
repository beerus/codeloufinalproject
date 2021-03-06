﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LetsTryAgain.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public string Roster { get; set; }
        public string Division { get; set; }
        public int NationalRank { get; set; }
        public int StateRank { get; set; }
        public ICollection<Player> Players { get; set; }
    } 
}