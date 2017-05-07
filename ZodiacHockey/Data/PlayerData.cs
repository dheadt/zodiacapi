using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacHockey.Data
{
    public class PlayerData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerDataId { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int Provider { get; set; }

        public int Salary { get; set; }
        public decimal FPPG { get; set; }
        public string Status { get; set; }
        public int GamesPlayed { get; set; }
        public string Position { get; set; }
        public DateTime GameDate { get; set; }
        public string MatchUp { get; set; }
        public int Assists { get; set; }
        public int Blocks { get; set; }
        public int Goals { get; set; }
        public int PowerPointsAssists { get; set; }
        public int PowerPointGoals { get; set; }
        public int Shots { get; set; }
        public int ShotsAgainest { get; set; }
        public int ShortHandedGoals { get; set; }
        public int GoalAgainest { get; set; }
        public int ShutOuts { get; set; }
        public int Saves { get; set; }
        public int Wins { get; set; }

    }
}
