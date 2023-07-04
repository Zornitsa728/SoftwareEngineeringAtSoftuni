namespace P01.ExperienceGaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            double collectedExperience = 0;
            int countSuccessBattles = 0;

            for (int i = 1; i <= countOfBattles; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());
                collectedExperience += experiencePerBattle;

                if (i % 3 == 0)
                {
                    collectedExperience += (experiencePerBattle * 0.15);
                }

                if (i % 5 == 0)
                {
                    collectedExperience -= (experiencePerBattle * 0.1);
                }

                if (i % 15 == 0)
                {
                    collectedExperience += (experiencePerBattle * 0.05);
                }

                if (collectedExperience >= neededExperience)
                {
                    countSuccessBattles = i;
                    break;
                }
            }

            if (collectedExperience >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {countSuccessBattles} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(neededExperience - collectedExperience):f2} more needed.");
            }
        }
    }
}