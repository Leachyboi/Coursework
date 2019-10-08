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
    public class DetailsModel : PageModel
    {
        private readonly CCFTracker.Data.ApplicationDbContext _context;

        public DetailsModel(CCFTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Qualification Qualification { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Qualification = await _context.Qualification.FirstOrDefaultAsync(m => m.ID == id);

            if (Qualification == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
