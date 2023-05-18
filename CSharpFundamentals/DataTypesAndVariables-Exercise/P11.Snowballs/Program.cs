using System.Numerics;

namespace P11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte allSnowballs = byte.Parse(Console.ReadLine());
            ushort snowballSnow;
            ushort snowballTime;
            ushort snowballQuality;
            BigInteger snowballValue = 0;
            BigInteger maxValue = int.MinValue;
            string bestResult = string.Empty;

            for (int currentBall = 1; currentBall <= allSnowballs; currentBall++)
            {
                snowballSnow = ushort.Parse(Console.ReadLine());
                snowballTime = ushort.Parse(Console.ReadLine());
                snowballQuality = ushort.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    bestResult = ($"{snowballSnow} : {snowballTime} = {maxValue} ({snowballQuality})");
                }
            }
            Console.WriteLine(bestResult);
        }
    }
}