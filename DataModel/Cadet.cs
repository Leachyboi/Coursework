using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCFTracker.DataModel
{
    public class Cadet
    {
        public int ID { get; set; }
        [StringLength(5, MinimumLength = 1)]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Required]
        public string Rank { get; set; }
        [StringLength(25, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Surname { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string KnownAs { get; set; }
        [Range(9, 13)]
        [Required]
        public int Year { get; set; }
        [StringLength(6, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Gender { get; set; }
        [StringLength(5, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]*$")]
        [Required]
        public string Form { get; set; }
        [Range(0, 2)]
        [Required]
        public int Platoon { get; set; }
        [Range(0, 3)]
        [Required]
        public int Section { get; set; }
    }
}
