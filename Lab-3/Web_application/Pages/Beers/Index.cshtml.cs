using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_application.Data;
using Web_application.models;

namespace Web_application.Pages.Beers
{
    public class IndexModel : PageModel
    {
        private readonly Web_application.Data.Web_applicationContext _context;

        public IndexModel(Web_application.Data.Web_applicationContext context)
        {
            _context = context;
        }

        public IList<Beer> Beer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Beer != null)
            {
                Beer = await _context.Beer.ToListAsync();
            }
        }
    }
}
