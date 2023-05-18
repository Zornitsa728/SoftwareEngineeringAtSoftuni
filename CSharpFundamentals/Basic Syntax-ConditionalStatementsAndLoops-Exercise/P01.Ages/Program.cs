namespace P01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string ageType = string.Empty;

            if (age >= 0 && age <= 2)
            {
                ageType = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                ageType = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                ageType = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                ageType = "adult";
            }
            else if (age >= 66)
            {
                ageType = "elder";
            }

            Console.WriteLine(ageType);
        }
    }
}