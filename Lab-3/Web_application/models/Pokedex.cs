namespace Web_application.models
{

    public class Pokedex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        
        public string? Image { get; set; }
        public List<PokedexType> Types { get; set; }
        public List<PokedexAbility> Abilities { get; set; }
    }

    public class PokedexType
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Type Type { get; set; }
    }

    public class Type
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PokedexAbility
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Ability Ability { get; set; }
    }

    public class Ability
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

    }

}