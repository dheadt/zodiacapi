using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacHockey.Data
{
    public class ZodiacSign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZodiacSignId { get; set; }
        [Required]
        public string ZodiacSignAbreviation { get; set; }
        [Required]
        public string Sign { get; set; }
        [Required]
        public DateTime Starts { get; set; }
        [Required]
        public DateTime Stops { get; set; }
    }
}
