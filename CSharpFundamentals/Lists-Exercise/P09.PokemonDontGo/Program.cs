using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace P09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int removedEl = 0;
            int sum = 0;

            while (input.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                if (IsIndexOutOfRange(input, ref removedEl, indexToRemove))
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removedEl)
                        {
                            input[i] += removedEl;
                        }
                        else
                        {
                            input[i] -= removedEl;
                        }
                    }
                }
                else
                {
                    removedEl = input[indexToRemove];
                    input.RemoveAt(indexToRemove);

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removedEl)
                        {
                            input[i] += removedEl;
                        }
                        else
                        {
                            input[i] -= removedEl;
                        }
                    }
                }

                sum += removedEl;
            }

            Console.WriteLine(sum);
        }

        static bool IsIndexOutOfRange(List<int> input,ref int removedEl, int indexToRemove)
        {
            if (indexToRemove < 0)
            {
                removedEl = input[0];
                input.RemoveAt(0);
                input.Insert(0, input[input.Count - 1]);
                return true;
            }
            else if (indexToRemove >= input.Count)
            {
                removedEl = input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
                input.Add(input[0]);
                return true;
            }

            return false;
        }
    }
}