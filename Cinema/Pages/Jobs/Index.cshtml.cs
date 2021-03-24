using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Identity.Data;
using Cinema.Data;
using Microsoft.AspNetCore.Authorization;

namespace Cinema.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly Cinema.Data.CinemaDBContext _context;

        public IndexModel(Cinema.Data.CinemaDBContext context)
        {
            _context = context;
        }

        public IList<Job> Job { get;set; }
      
        public async Task OnGetAsync()
        {
            Job = await _context.Jobs.ToListAsync();
        }
    }
}
