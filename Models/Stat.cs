using System.ComponentModel.DataAnnotations;

namespace LetsTryAgain.Models
{
    public class Stat
    {
        [Key]
        public string Opponent { get; set; }
        public int OpponentStateRanking { get; set; }
        public int OppenentNationalRanking { get; set; }
        public int Points { get; set; }
        public int Rebounds { get; set; }
        public int Steals { get; set; }
        public int Assist { get; set; }
        public int Blocks { get; set; }
        public int Turnovers { get; set; }
        public int MissedFieldGoals { get; set; }
        public int MissedFreeThrows { get; set; }
        public int Fouls { get; set; }
        public int MinutesPlayed { get; set; }
        public int Posessions { get; set; }
    }
}