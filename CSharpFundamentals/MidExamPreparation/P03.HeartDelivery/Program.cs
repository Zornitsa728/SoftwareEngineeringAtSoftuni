namespace P03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();
            string input;
            int lastJump = 0;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] inputToArray = input.Split();
                int jumpLength = int.Parse(inputToArray[1]);
                int currJump = jumpLength + lastJump;

                if (currJump >= houses.Count)
                {
                    if (houses[0] == 0)
                    {
                        Console.WriteLine($"Place 0 already had Valentine's day.");
                    }
                    else
                    {
                        houses[0] -= 2;
                        if (houses[0] == 0)
                        {
                            Console.WriteLine($"Place 0 has Valentine's day.");
                        }
                    }
                    lastJump = 0;
                    continue;
                }
                else
                {
                    if (houses[currJump] == 0)
                    {
                        Console.WriteLine($"Place {currJump} already had Valentine's day.");
                    }
                    else
                    {
                        houses[currJump] -= 2;
                        if (houses[currJump] == 0)
                        {
                            Console.WriteLine($"Place {currJump} has Valentine's day.");
                        }
                    }
                }

                lastJump += jumpLength;
            }

            Console.WriteLine($"Cupid's last position was {lastJump}.");
            int countSucces = 0;
            foreach ( var house in houses )
            {
                if (house == 0)
                {
                    countSucces++;
                }
            }

            if (countSucces == houses.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int countFailed = (houses.Count) - countSucces;
                Console.WriteLine($"Cupid has failed {countFailed} places.");
            }
        }
    }
}