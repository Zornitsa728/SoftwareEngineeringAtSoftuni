namespace P01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine()); // perHour
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int allStudents = int.Parse(Console.ReadLine());

            int sumAllEmployeeEfficienty = firstEmployee + secondEmployee + thirdEmployee;
            int countHours = 0;

            while (allStudents > 0)
            {
                countHours++;
                if (countHours % 4 == 0)
                {
                    continue;
                }

                allStudents -= sumAllEmployeeEfficienty;
            }
            Console.WriteLine($"Time needed: {countHours}h.");
        }
    }
}