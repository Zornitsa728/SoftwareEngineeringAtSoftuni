namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] ints = ArrayCreator.Create(13, 3);

            Console.WriteLine(string.Join(" ",strings));
            Console.WriteLine(string.Join(" ",ints));
        }
    }
}