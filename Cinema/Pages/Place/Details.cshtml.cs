using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Identity.Data;
using Cinema.Data;

namespace Cinema.Pages.Place
{
    public class DetailsModel : PageModel
    {
        private readonly Cinema.Data.CinemaDBContext _context;

        public DetailsModel(Cinema.Data.CinemaDBContext context)
        {
            _context = context;
        }

        public Areas.Identity.Data.Place Place { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Place = await _context.Places
                .Include(p => p.Hall)
                .Include(p => p.Session).FirstOrDefaultAsync(m => m.PlaceNumber == id);

            if (Place == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
