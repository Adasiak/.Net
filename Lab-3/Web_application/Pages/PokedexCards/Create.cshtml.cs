using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_application.models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Web_application.Pages.PokedexCards
{
    public class CreateModel : PageModel
    {
        private readonly PokemonCards _context;

        public CreateModel(PokemonCards context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pokedex Pokedex { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (_context.Pokedex == null || Pokedex == null)
            {
                return Page();
            }

            _context.Pokedex.Add(await AddPokemonAsync(Pokedex.Name));
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");


        }

        public async Task<Pokedex> AddPokemonAsync(string api)
        {
            string call = "https://pokeapi.co/api/v2/pokemon/" + api;
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            var pokemon = JsonConvert.DeserializeObject<Pokedex>(response);
            var pokemoncard = new Pokedex
            {
                Name = pokemon.Name,
                Weight = pokemon.Weight,
                Height = pokemon.Height,
                Image = Pokedex.Image,
                Abilities = pokemon.Abilities,
                Types = pokemon.Types
            };
            

            return pokemoncard;
        }
    }
}
