using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Identity.Data;
using Cinema.Data;

namespace Cinema.Pages.Films
{
    public class DetailsModel : PageModel
    {
        private readonly Cinema.Data.CinemaDBContext _context;

        public DetailsModel(Cinema.Data.CinemaDBContext context)
        {
            _context = context;
        }

        public Film Film { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Films
                .Include(f => f.Genre).FirstOrDefaultAsync(m => m.FilmId == id);

            if (Film == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
