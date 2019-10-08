using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CCFTracker.Data;
using CCFTracker.DataModel;
using CCFTracker.ViewModel;

namespace CCFTracker.Pages.Cadets
{
    public class IndexModel : PageModel
    {
        private readonly CCFTracker.Data.ApplicationDbContext _context;

        public IndexModel(CCFTracker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cadet> Cadet { get;set; }

        public async Task OnGetAsync()
        {
            var cadets = from i in _context.Cadet
                         select i;
            Cadet = await _context.Cadet.ToListAsync();
        }
    }
}
