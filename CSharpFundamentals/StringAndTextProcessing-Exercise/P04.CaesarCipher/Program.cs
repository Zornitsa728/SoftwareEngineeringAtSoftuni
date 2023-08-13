using System.Text;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            
            for (int i = 0; i < input.Length; i++)
            {
                output += ((char)(input[i] + 3));
            }

            Console.WriteLine(output);
        }
    }
}