using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacHockey.Data
{
    public class ZodiacWeakness
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZodiacWeaknessId { get; set; }
        [Required]
        public int ZodiacSign { get; set; }
        [Required]
        public string Weakness { get; set; }
    }
}
