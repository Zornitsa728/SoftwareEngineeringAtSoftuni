using System.Text;

namespace P05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string correctPassword = string.Empty;
            int count = 0;

            while (true)
            {
                if (correctPassword == string.Empty)
                {
                    for (int i = username.Length - 1; i >= 0; i--)
                    {
                        correctPassword += (username[i]);
                    }
                }

                if (correctPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
                password = Console.ReadLine();
            }
        }
    }
}