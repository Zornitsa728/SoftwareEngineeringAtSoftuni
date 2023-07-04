namespace P01.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] currStateOfTheLift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < currStateOfTheLift.Length; i++)
            {
                if (currStateOfTheLift[i] < 4 && waitingPeople > 0)
                {
                    int peopleBoarding = 4 - currStateOfTheLift[i];
                    if (peopleBoarding > waitingPeople)
                    {
                        peopleBoarding = waitingPeople;
                    }

                    waitingPeople -= peopleBoarding;
                    currStateOfTheLift[i] += peopleBoarding;
                }

                if (waitingPeople == 0)
                {
                    break;
                }
            }

            int countEmptySeats = 0;
            foreach (int wagon in currStateOfTheLift)
            {
                if (!wagon.Equals(4))
                {
                    countEmptySeats++;
                }
            }

            if (waitingPeople == 0 && countEmptySeats > 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', currStateOfTheLift));
            }
            else if (waitingPeople > 0 && countEmptySeats == 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(' ', currStateOfTheLift));
            }
            else if(waitingPeople == 0 && countEmptySeats == 0)
            {
                Console.WriteLine(string.Join(' ', currStateOfTheLift));
            }
        }
    }
}