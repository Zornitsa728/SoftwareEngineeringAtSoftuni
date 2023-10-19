namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> numbers = new CustomStack<int>();
            string cmd;

            while ((cmd = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = cmd
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string operation = cmdArgs[0];

                switch (operation)
                {
                    case "Push":
                        for (int i = 1; i < cmdArgs.Length; i++)
                        {
                            numbers.Push(int.Parse(cmdArgs[i]));
                        }
                        break;
                    case "Pop":
                        try
                        {
                            numbers.Pop();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}