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
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Display(Name = "Class")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public string Year { get; set; }
        [Display(Name = "Position")]
        public string Position { get; set; }
        [Display(Name = "National Ranking")]
        [Range(1, 999)]
        public int Ranking { get; set; }
        [Display(Name = "Prospect Level")]
        [Range(1, 5)]
        public int ProspectLevel { get; set; }
        [Display(Name = "Chips")]
        [Range(0, 2)]
        public int ChipLevel { get; set; }
        [Display(Name = "Add Game Stats")]
        public virtual ICollection<Stat> Stats { get; set; }
        [Display(Name = "Add Team")]
        public virtual Team Team { get; set; }
        [Display(Name = "Commit Status")]
        public bool CommitStatus { get; set; }
        [Display(Name = "Heavily Scouted")]
        public bool Sleeper { get; set; }
        [Display(Name = "Eligible")]
        public bool Eligible { get; set; }

    }

      public enum ChipLevel
        {
        None,
        Blue,
        Gold,
        }
}
