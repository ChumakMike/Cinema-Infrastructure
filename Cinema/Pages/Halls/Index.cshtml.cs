using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Identity.Data;
using Cinema.Data;

namespace Cinema.Pages.Halls
{
    public class IndexModel : PageModel
    {
        private readonly Cinema.Data.CinemaDBContext _context;

        public IndexModel(Cinema.Data.CinemaDBContext context)
        {
            _context = context;
        }

        public IList<Hall> Hall { get;set; }

        public async Task OnGetAsync()
        {
            Hall = await _context.Halls.ToListAsync();
        }
    }
}
