using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        private List<Pokemon> pokemons;
        public Trainer(string name)
        {
            Name = name;
            pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get { return pokemons; } set {; } }
        public void AddPokemon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }
    }
}
