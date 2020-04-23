using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsTryAgain.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Year { get; set; }
        public string Position { get; set; }
        public int Ranking { get; set; }
        public int ProspectLevel { get; set; }
        public int ChipLevel { get; set; }
        public virtual ICollection<Stat> Stats { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public bool CommitStatus { get; set; }
        public bool Potential { get; set; }
        public bool Sleeper { get; set; }
        public bool Eligible { get; set; }

    }
}
