decimal[] prices = Console.ReadLine()
				.Split(", ",StringSplitOptions.RemoveEmptyEntries)
				.Select(decimal.Parse)
				.Select(p => p * 1.2M)
				.ToArray();

foreach (decimal price in prices)
{
    Console.WriteLine($"{price:f2}");
}

