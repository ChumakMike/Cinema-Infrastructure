using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cinema.Areas.Identity.Data;
using Cinema.Data;

namespace Cinema.Pages.Place
{
    public class CreateModel : PageModel
    {
        private readonly Cinema.Data.CinemaDBContext _context;

        public CreateModel(Cinema.Data.CinemaDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["HallId"] = new SelectList(_context.Halls, "HallId", "Name");
        ViewData["SessionId"] = new SelectList(_context.Sessions, "SessionId", "ShowDate");
            return Page();
        }

        [BindProperty]
        public Cinema.Areas.Identity.Data.Place Place { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Places.Add(Place);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
