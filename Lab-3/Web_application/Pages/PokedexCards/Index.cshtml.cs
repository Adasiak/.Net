using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Web_application.models;

namespace Web_application.Pages.PokedexCards
{
    public class IndexModel : PageModel
    {
        private readonly PokemonCards _context;

        public IndexModel(PokemonCards context)
        {
            _context = context;
        }

        public IList<Pokedex> Pokedex { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pokedex != null)
            {    

                Pokedex = await _context.Pokedex.Include(x=>x.Abilities).ThenInclude(x=>x.Ability).Include(x=>x.Types).ThenInclude(x=>x.Type).ToListAsync();
            }
        }
       
    }
}
