using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Tournament")
                {
                    break;
                }

                string trainerName = input[0];
                string pokemonName = input[1];
                string element = input[2];
                int health = int.Parse(input[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers[trainerName] = trainer;
                }

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                trainers[trainerName].AddPokemon(pokemon);
            }

            while (true)
            {
                string element = Console.ReadLine();

                if (element == "End")
                {
                    break;
                }

                foreach (Trainer trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.ReceiveBadge();
                    }
                    else
                    {
                        trainer.DamageAllPokemons(10);
                    }
                }
            }

            Dictionary<string, Trainer> sortedTrainers = trainers
                .OrderByDescending(t => t.Value.Badges)
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Key} - {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}