using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacHockey.Data
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }
        [Required]
        public string TeamAbreviationId { get; set; }
        [Required]
        public string Division { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string TeamName { get; set; }
    }
}
