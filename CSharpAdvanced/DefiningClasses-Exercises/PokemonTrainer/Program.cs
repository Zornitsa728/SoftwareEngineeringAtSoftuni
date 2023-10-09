using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Trainer> trainers = new List<Trainer>();
            input = AddTrainerWithPokemons(trainers);
            input = CheckIfPokemonExist(trainers);

            foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static string CheckIfPokemonExist(List<Trainer> trainers)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            Pokemon currPokemon = trainer.Pokemons[i];
                            currPokemon.Health -= 10;

                            if (currPokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(currPokemon);
                            }
                        }
                    }
                }
            }

            return input;
        }

        private static string AddTrainerWithPokemons(List<Trainer> trainers)
        {
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Pokemon pokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));

                if (trainers.Any(t => t.Name == tokens[0]))
                {
                    Trainer currTrainer = trainers.First(t => t.Name == tokens[0]);
                    currTrainer.AddPokemon(pokemon);
                    continue;
                }

                Trainer trainer = new Trainer(tokens[0]);
                trainer.AddPokemon(pokemon);

                trainers.Add(trainer);
            }

            return input;
        }
    }
}