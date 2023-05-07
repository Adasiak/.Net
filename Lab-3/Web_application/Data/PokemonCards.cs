using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_application.models;

    public class PokemonCards : DbContext
    {
        public PokemonCards (DbContextOptions<PokemonCards> options)
            : base(options)
        {
        }

        public DbSet<Web_application.models.Pokedex> Pokedex { get; set; } = default!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Pokedex>()
            .HasMany(x => x.Abilities)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Pokedex>()
           .HasMany(x => x.Types)
           .WithOne()
           .OnDelete(DeleteBehavior.Cascade);
    }

}

