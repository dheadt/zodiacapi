using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZodiacHockey.Data
{
    public class Player
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string NickName { get; set; }
        [Required]
        public int Position { get; set; }
        [Required]
        public int PositionType { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }
        public string BirthNation { get; set; }
        [Required]
        public TimeSpan BirthTime { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Shoots { get; set; }
        [Required]
        public int DraftTeam { get; set; }
        public int DraftRound { get; set; }
        public int DraftNumber { get; set; }
        public int DraftYear { get; set; }
        [Required]
        public int SunSign { get; set; }
        [Required]
        public int MoonSign { get; set; }
        [Required]
        public int MercurySign { get; set; }
        [Required]
        public int VenusSign { get; set; }
        [Required]
        public int MarsSign { get; set; }
        [Required]
        public int JupiterSign { get; set; }
        [Required]
        public int SaturnSign { get; set; }
        [Required]
        public int UranisSign { get; set; }
        [Required]
        public int NeptuneSign { get; set; }
        [Required]
        public int PlutoSign { get; set; }
        [Required]
        public int TrueNode { get; set; }
        [Required]
        public int Ascendant { get; set; }
        [Required]
        public int LifePath { get; set; }
        public string ChineseSign { get; set; }
        public string ElementSun { get; set; }
        public string ElmentMercury { get; set; }
        public string ElementVenus { get; set; }
        public string ElmentMars { get; set; }
        public string ElmentJupiter { get; set; }
        public string ElmentSaturn { get; set; }
        public string ElmentUranus { get; set; }
        public string ElmentNeptune { get; set; }
        public string ElmentPluto { get; set; }
        public int WaterSigns { get; set; }
    }
}
