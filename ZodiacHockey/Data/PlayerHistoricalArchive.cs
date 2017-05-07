using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ZodiacHockey.Data
{
    public class PlayerHistoricalArchive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerHIstoricalArchiveId { get; set; }
        [Required]
        public int PlayerId { get; set; }

        public string Status { get; set; }
        [Required]
        public int Number { get; set; }

        public string Season { get; set; }
        [Required]
        public int Team { get; set; }
        [Required]
        public int League { get; set; }
        [Required]
        public int Line { get; set; }
        [Required]
        public string PowerPlayUnit { get; set; }
        [Required]
        public int GP { get; set; }

        public int G { get; set; }
        public int A { get; set; }
        public int PTS { get; set; }
        public int PlusMinus { get; set; }
        public int PIM { get; set; }
        public int TOI { get; set; }
        public int ATOI { get; set; }
        public int FOPercent { get; set; }
        public int HIT { get; set; }
        public int BLK { get; set; }
        public int TK { get; set; }
    }
}
