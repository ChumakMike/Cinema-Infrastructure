using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Identity.Data;
using Cinema.Data;

namespace Cinema.Pages.Place
{
    public class EditModel : PageModel
    {
        private readonly Cinema.Data.CinemaDBContext _context;

        public EditModel(Cinema.Data.CinemaDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["HallId"] = new SelectList(_context.Halls, "HallId", "Name");
           ViewData["SessionId"] = new SelectList(_context.Sessions, "SessionId", "ShowDate");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Place).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaceExists(Place.PlaceNumber))
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

        private bool PlaceExists(int id)
        {
            return _context.Places.Any(e => e.PlaceNumber == id);
        }
    }
}
