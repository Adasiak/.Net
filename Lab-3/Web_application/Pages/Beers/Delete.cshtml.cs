﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Web_application.Data.Web_applicationContext _context;

        public DeleteModel(Web_application.Data.Web_applicationContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Beer Beer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Beer == null)
            {
                return NotFound();
            }

            var beer = await _context.Beer.FirstOrDefaultAsync(m => m.Id == id);

            if (beer == null)
            {
                return NotFound();
            }
            else 
            {
                Beer = beer;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Beer == null)
            {
                return NotFound();
            }
            var beer = await _context.Beer.FindAsync(id);

            if (beer != null)
            {
                Beer = beer;
                _context.Beer.Remove(Beer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
