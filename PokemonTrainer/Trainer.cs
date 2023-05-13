using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Badges
        {
            get
            {
                return this.badges;
            }
            set
            {
                this.badges = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void ReceiveBadge()
        {
            this.Badges++;
        }

        public void DamageAllPokemons(int damage)
        {
            foreach (var pokemon in this.Pokemons)
            {
                pokemon.Health -= damage;
            }

            this.Pokemons = this.Pokemons.Where(p => p.Health > 0).ToList();
        }
    }
}