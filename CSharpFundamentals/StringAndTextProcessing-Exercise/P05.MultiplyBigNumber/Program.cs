using System.Text;

namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int onMind = 0;

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int lastNum = int.Parse(bigNum[i].ToString());
                int result = lastNum * multiplier + onMind;

                sb.Append(result % 10);

                onMind = result / 10;
            }

            if (onMind != 0)
            {
                sb.Append(onMind);
            }

            string resultNum = string.Join("", sb.ToString().Reverse()).TrimStart('0');

            if (resultNum == string.Empty)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(resultNum);
            }
        }
    }
}