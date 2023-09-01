int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());
int memoryGreenDuration = greenLightDuration;
string input;
Queue<string> cars = new Queue<string>();
string substring = string.Empty;
int passedCars = 0;

while ((input = Console.ReadLine()) != "END")
{
    if (input == "green")
    {
        string currCar = string.Empty;
        
        while (greenLightDuration > 0 && cars.Any())
        {
            currCar = cars.Dequeue();
            passedCars++;
            if (currCar.Length <= greenLightDuration)
            {
                greenLightDuration -= currCar.Length;
            }
            else
            {
                substring = currCar.Substring(greenLightDuration);
                greenLightDuration = 0;
            }
        }
        greenLightDuration = memoryGreenDuration;

        if (freeWindowDuration >= substring.Length)
        {
            continue;
        }
        else
        {
            substring = substring.Substring(freeWindowDuration);
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{currCar} was hit at {substring.First()}.");
            return;
        }
    }
    else
    {
        cars.Enqueue(input);
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCars} total cars passed the crossroads.");

