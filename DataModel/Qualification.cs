using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCFTracker.DataModel
{
    public class Qualification
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string QualName { get; set; }

        public int PassMark { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string ParOrChi { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Parent { get; set; }
        public int NumChi { get; set; }
        public int MinChiPass { get; set; }
    }
}
