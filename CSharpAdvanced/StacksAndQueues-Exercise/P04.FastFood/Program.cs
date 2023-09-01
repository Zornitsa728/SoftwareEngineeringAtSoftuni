using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>
                (Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            bool isOrdersCoplete = true;

            if (orders.Any())
            {
                Console.WriteLine(orders.Max());

                while (orders.Any())
                {
                    if (food >= orders.Peek())
                    {
                        food -= orders.Dequeue();
                    }
                    else
                    {
                        isOrdersCoplete = false;
                        break;
                    }
                }
            }

            if (isOrdersCoplete)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}