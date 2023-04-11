using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Ability> Abilities { get; set; }
    }

    public class Ability
    {
        public AbilityDetail ability { get; set; }
    }

    public class AbilityDetail
    {
        public string Name { get; set; }
    }

}
