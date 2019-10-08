using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CCFTracker.Data;
using CCFTracker.DataModel;

namespace CCFTracker.Pages.Cadets
{
    public class CreateModel : PageModel
    {
        private readonly CCFTracker.Data.ApplicationDbContext _context;

        public CreateModel(CCFTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cadet Cadet { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cadet.Add(Cadet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}