using System.Collections.Generic;

namespace P00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (type == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
        }

        static int GetMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }

        static char GetMax(char firstChar, char secondChar)
        {
            return (char)Math.Max(firstChar, secondChar);
        }
        static string GetMax(string firstText, string secondText)
        {
            int comparison = firstText.CompareTo(secondText);
            if (comparison > 0)
            {
                return firstText;
            }
            else
            {
                return secondText;
            }
        }
    }
}