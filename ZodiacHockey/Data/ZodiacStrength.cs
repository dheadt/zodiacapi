using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacHockey.Data
{
    public class ZodiacStrength
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZodiacStrengthId { get; set; }
        [Required]
        public int ZodiacSign { get; set; }
        [Required]
        public string Strength { get; set; }
    }
}
