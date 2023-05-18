namespace P05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string number = string.Empty;
            char symbol = 'a';
            string output = string.Empty;

            for (int i = 0; i < input; i++)
            {
                number = Console.ReadLine();
                if (number == "0")
                {
                    output += ' ';
                    continue;
                }

                if (number.Length == 4)
                {
                    if (number == "7777")
                    {
                        symbol = 's';
                    }
                    else if (number == "9999")
                    {
                        symbol = 'z';
                    }
                }
                else if (number.Length == 3)
                {
                    switch (number)
                    {
                        case "222":
                        symbol = 'c';
                            break;
                        case "333":
                            symbol = 'f';
                            break;
                        case "444":
                            symbol = 'i';
                            break;
                        case "555":
                            symbol = 'l';
                            break;
                        case "666":
                            symbol = 'o';
                            break;
                        case "777":
                            symbol = 'r';
                            break;
                        case "888":
                            symbol = 'v';
                            break;
                        case "999":
                            symbol = 'y';
                            break;
                    }
                }
                else if(number.Length == 2)
                {
                    switch (number)
                    {
                        case "22":
                            symbol = 'b';
                            break;
                        case "33":
                            symbol = 'e';
                            break;
                        case "44":
                            symbol = 'h';
                            break;
                        case "55":
                            symbol = 'k';
                            break;
                        case "66":
                            symbol = 'n';
                            break;
                        case "77":
                            symbol = 'q';
                            break;
                        case "88":
                            symbol = 'u';
                            break;
                        case "99":
                            symbol = 'x';
                            break;
                    }
                }
                else if (number.Length == 1)
                {
                    switch (number)
                    {
                        case "2":
                            symbol = 'a';
                            break;
                        case "3":
                            symbol = 'd';
                            break;
                        case "4":
                            symbol = 'g';
                            break;
                        case "5":
                            symbol = 'j';
                            break;
                        case "6":
                            symbol = 'm';
                            break;
                        case "7":
                            symbol = 'p';
                            break;
                        case "8":
                            symbol = 't';
                            break;
                        case "9":
                            symbol = 'w';
                            break;
                    }
                }

                output += symbol;
            }

            Console.WriteLine(output);
        }
    }
}