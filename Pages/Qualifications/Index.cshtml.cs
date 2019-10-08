using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CCFTracker.Data;
using CCFTracker.DataModel;

namespace CCFTracker.Pages.Qualifications
{
    public class IndexModel : PageModel
    {
        private readonly CCFTracker.Data.ApplicationDbContext _context;

        public IndexModel(CCFTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Qualification> Qualification { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ColumnFilter { get; set; }

        public async Task OnGetAsync()
        {
            var qualifications = from i in _context.Qualification
                                 select i;

            if (ColumnFilter == "QualName")
            {
                if (!string.IsNullOrEmpty(SortString))
                {
                    qualifications = qualifications.Where(s => s.QualName.Contains(SortString));
                }
            }
            if (ColumnFilter == "ParOrChi")
            {
                if (!string.IsNullOrEmpty(SortString))
                {
                    qualifications = qualifications.Where(s => s.ParOrChi.Contains(SortString));
                }
            }
            if (ColumnFilter == "Parent")
            {
                if (!string.IsNullOrEmpty(SortString))
                {
                    qualifications = qualifications.Where(s => s.Parent.Contains(SortString));
                }
            }

            Qualification = await qualifications.ToListAsync();
        }
    }
}
