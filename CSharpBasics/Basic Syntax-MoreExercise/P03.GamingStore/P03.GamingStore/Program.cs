namespace P03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string gameName;
            double price = 0;
            double totalSpent = 0;

            while ((gameName=Console.ReadLine()) != "Game Time")
            {
                if(gameName == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (gameName == "CS: OG")
                {
                    price = 15.99;
                }
                else if(gameName == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (gameName == "Honored 2")
                {
                    price = 59.99;
                }
                else if (gameName == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (price > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    totalSpent += price;
                    currentBalance -= price;
                    Console.WriteLine($"Bought {gameName}");
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

            }

            if(currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
            }
            
        }
    }
}