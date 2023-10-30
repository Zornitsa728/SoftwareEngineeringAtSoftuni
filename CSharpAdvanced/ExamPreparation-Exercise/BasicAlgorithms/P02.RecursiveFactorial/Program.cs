int number = int.Parse(Console.ReadLine());
Console.WriteLine(RecursiveFactorial(number));

long RecursiveFactorial(int n)
{
    if (n == 1)
    {
        return 1;
    }

    return n * RecursiveFactorial(n - 1);
}
