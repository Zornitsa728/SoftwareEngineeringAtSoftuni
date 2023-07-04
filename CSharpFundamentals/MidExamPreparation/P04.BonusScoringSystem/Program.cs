namespace P04.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsNum = int.Parse(Console.ReadLine());
            int lecturesNum = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            int maxBonus = 0;
            int maxLectures = 0;

            for (int CurrStudent = 0; CurrStudent < studentsNum; CurrStudent++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double totalBonus = Math.Round((double)attendance / lecturesNum * (5 + additionalBonus));

                if (totalBonus > maxBonus)
                {
                    maxBonus = (int)totalBonus;
                    maxLectures = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}