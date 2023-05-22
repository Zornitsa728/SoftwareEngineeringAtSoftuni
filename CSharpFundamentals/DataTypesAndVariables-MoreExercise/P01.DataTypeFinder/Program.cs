using System.ComponentModel.Design;

namespace P01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string type = string.Empty;

            while ((input = Console.ReadLine()) != "END" )
            {
                if (int.TryParse(input, out _))
                {
                    type = "integer";
                }
                else if (double.TryParse(input, out _))
                {
                    type = "floating point";
                }
                else if (char.TryParse(input, out _))
                {
                    type = "character";
                }
                else if (bool.TryParse(input, out _))
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }

                Console.WriteLine($"{input} is {type} type");
            }

        }
    }
}