using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    public class Pokemon
    {
        public int ID { set; get; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Ability> Abilities { get; set; }
    }

    public class Ability
    {
        public int ID { set; get; }
        public AbilityDetail ability { get; set; }
    }

    public class AbilityDetail
    {
        public int ID { set; get; }
        public string Name { get; set; }
    }

    public class Pokedex1 : DbContext
    {
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public Pokedex1() { Database.EnsureCreated(); }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
=> options.UseSqlite(@"Data Source=poke1.db");


    }


}
