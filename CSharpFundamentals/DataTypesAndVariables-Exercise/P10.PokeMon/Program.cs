using System.Collections.Generic;

namespace P10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint pokePower = uint.Parse(Console.ReadLine()); //N
            uint distance = uint.Parse(Console.ReadLine()); //M
            byte exhaustionFactor = byte.Parse(Console.ReadLine()); //Y
            uint startingPokePower = pokePower;
            uint allTargets = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                allTargets++;
                if (pokePower == startingPokePower / 2 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(allTargets);
        }
    }
}