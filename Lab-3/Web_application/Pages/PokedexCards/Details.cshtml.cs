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
    public class DetailsModel : PageModel
    {
        private readonly PokemonCards _context;

        public DetailsModel(PokemonCards context)
        {
            _context = context;
        }

      public Pokedex Pokedex { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null || _context.Pokedex == null)
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
    }
}
