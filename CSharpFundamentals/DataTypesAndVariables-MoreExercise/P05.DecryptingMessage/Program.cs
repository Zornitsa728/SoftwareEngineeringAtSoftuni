namespace P05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int characters = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < characters; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                int decrypted = currentChar + key;
                message += (char)decrypted;
            }

            Console.WriteLine(message);
        }
    }
}