namespace P05.PrintPar_OfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int currentChar = startNum; currentChar <= endNum; currentChar++)
            {
                Console.Write($"{(char)currentChar} ");
            }
        }
    }
}