using System;

namespace P01.Stream_Progress.Interfaces
{
    public class Engine : IEngine
    {
        public void Run()
        {
            Console.WriteLine($"Choose your stream preference:{Environment.NewLine}Type File or Music ?");
            string userPreference = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userPreference))
            {
                throw new ArgumentNullException("Please write your stream preference!");
            }

            IStream stream = null;

            string[] tokens = null;

            switch (userPreference.ToLower())
            {
                case "file":
                    Console.WriteLine($"You choose {userPreference}! Write on the same line Name, Length and Bytes sent");

                    tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (tokens.Length < 3)
                    {
                        throw new ArgumentOutOfRangeException($"Please, write everything on the same line separated by spaces.{Environment.NewLine}Lets try again from the beginning!");
                    }

                    string name = tokens[0];
                    int length = int.Parse(tokens[1]);
                    int bytesSent = int.Parse(tokens[2]);

                    stream = new File(name, length, bytesSent);
                    break;
                case "music":
                    Console.WriteLine($"You choose {userPreference}! Write on the same line Artist, Album, Length, Bytes sent");

                    tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (tokens.Length < 3)
                    {
                        throw new ArgumentOutOfRangeException($"Please, write everything on the same line separated by spaces.{Environment.NewLine}Lets try again from the beginning!");
                    }

                    name = tokens[0];
                    string albumName = tokens[1];
                    length = int.Parse(tokens[1]);
                    bytesSent = int.Parse(tokens[2]);

                    stream = new Music(name, albumName, length, bytesSent);
                    break;
                default:
                    throw new ArgumentException("Invalid type! Try again.");
            }

            StreamProgressInfo progressInfo = new StreamProgressInfo(stream);

            Console.WriteLine($"Current percent: {progressInfo.CalculateCurrentPercent()}");
        }
    }
}
