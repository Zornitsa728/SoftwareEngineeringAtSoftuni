using System;

namespace P05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете текст (стринг)
            string text = Console.ReadLine();
            int length = text.Length;
            //печата всеки символ от текста на отделен ред
            for (int i=0; length>i; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }
        }
    }
}
