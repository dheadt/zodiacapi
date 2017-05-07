using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacHockey.Data
{
    public class PositionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionTypeId { get; set; }
        [Required]
        public string PositionTypeAbbreviation { get; set; }
        [Required]
        public string PositionTypeName { get; set; }
    }
}
