using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_application.models;

namespace Web_application.Pages.PokedexCards
{
    public class DeleteModel : PageModel
    {
        private readonly PokemonCards _context;

        public DeleteModel(PokemonCards context)
        {
            _context = context;
        }

        [BindProperty]
      public Pokedex Pokedex { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (_context.Pokedex == null)
            {
                return NotFound();
            }

            var pokedex = await _context.Pokedex.FirstOrDefaultAsync(m => m.Id == id);

            if (pokedex == null)
            {
                return NotFound();
            }
            else 
            {
                Pokedex = pokedex;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (_context.Pokedex == null)
            {
                return NotFound();
            }
             var pokedex = await _context.Pokedex
                .Include(x => x.Abilities)
                .ThenInclude(x => x.Ability)
                .Include(x => x.Types)
                .ThenInclude(x => x.Type)
                .FirstOrDefaultAsync(m => m.Id == id); 
            

            if (pokedex != null)
            {
                Pokedex = pokedex;
                _context.Pokedex.Remove(Pokedex);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
