using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCFTracker.ViewModel
{
    public class CadetView
    {
        public int ID { get; set; }
        public string Rank { get; set; }

        public string FullName { get; set; }
        [Display(Name = "School Year")]
        public int Year { get; set; }
        public string Gender { get; set; }
        public string Form { get; set; }
        public string GroupLocation { get; set; }
    }
}
