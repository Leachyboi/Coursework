using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCFTracker.ViewModel
{
    public class QualificationView
    {
        public int ID { get; set; }
        [Display(Name = "Qualification Name")]
        public string QualName { get; set; }

        [Display(Name = "Pass Mark")]
        public int PassMark { get; set; }
        [Display(Name = "Parent or Child")]
        public string ParOrChi { get; set; }
        public string Parent { get; set; }
        [Display(Name = "Number of Children")]
        public int NumChi { get; set; }
        [Display(Name = "Mininum Children passed to pass")]
        public int MinChiPass { get; set; }
    }
}
