using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_application.models;

namespace Web_application.Pages.PokedexCards
{
    public class EditModel : PageModel
    {
        private readonly PokemonCards _context;

        public EditModel(PokemonCards context)
        {
            _context = context;
        }

        [BindProperty]
        public Pokedex Pokedex { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _context.Pokedex == null)
            {
                return NotFound();
            }

            var pokedex =  await _context.Pokedex.FirstOrDefaultAsync(m => m.Id == id);
            if (pokedex == null)
            {
                return NotFound();
            }
            Pokedex = pokedex;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pokedex).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PokedexExists(Pokedex.Id))
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

        private bool PokedexExists(int id)
        {
          return (_context.Pokedex?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
