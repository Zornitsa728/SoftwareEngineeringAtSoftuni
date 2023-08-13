namespace P01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string cmd = string.Empty;

            while((cmd = Console.ReadLine()) != "Done")
            {
                string newPassword = string.Empty;
                string[] cmdArgs = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string operation = cmdArgs[0];

                if (operation == "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPassword += password[i];
                        }
                    }

                    Console.WriteLine(newPassword);
                    password = newPassword;
                }
                else if (operation == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if(operation == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string subtstitute = cmdArgs[2];

                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }

                    password = password.Replace(substring, subtstitute);
                    Console.WriteLine(password);
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}