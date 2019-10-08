using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CCFTracker.Data;
using CCFTracker.DataModel;

namespace CCFTracker.Pages.Cadets
{
    public class EditModel : PageModel
    {
        private readonly CCFTracker.Data.ApplicationDbContext _context;

        public EditModel(CCFTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cadet Cadet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cadet = await _context.Cadet.FirstOrDefaultAsync(m => m.ID == id);

            if (Cadet == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cadet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CadetExists(Cadet.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CadetExists(int id)
        {
            return _context.Cadet.Any(e => e.ID == id);
        }
    }
}
