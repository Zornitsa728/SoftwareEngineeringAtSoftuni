namespace P03.PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                 .Split(", ")
                 .ToList();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split(" - ");
                
                if (cmd[0] == "Add")
                {
                    if (!DoesPhoneExists(phones, cmd))
                    {
                        phones.Add(cmd[1]);
                    }
                }
                else if (cmd[0] == "Remove")
                {
                    if (DoesPhoneExists(phones, cmd))
                    {
                        phones.Remove(cmd[1]);
                    }
                }
                else if (cmd[0] == "Bonus phone")
                {
                    BonusPhone(phones, cmd);
                }
                else if (cmd[0] == "Last")
                {
                    if (DoesPhoneExists(phones, cmd))
                    {
                        LastPhone(phones, cmd);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }

        static bool DoesPhoneExists(List<string> phones, string[] cmd)
        {
            string phone = cmd[1];
            if (phones.Contains(phone))
            {
                return true;
            }

            return false;
        }

        static void BonusPhone(List<string> phones, string[] cmd)
        {
            string[] oldAndNewPhones = cmd[1].Split(":");
            if (phones.Contains(oldAndNewPhones[0]))
            {
                for (int i = 0; i < phones.Count; i++)
                {
                    if (phones[i] == oldAndNewPhones[0])
                    {
                        phones.Insert(i + 1, oldAndNewPhones[1]);
                        break;
                    }
                }
            }
        }

        static void LastPhone(List<string> phones, string[] cmd)
        {
            for (int i = 0; i < phones.Count; i++)
            {
                if (phones[i] == cmd[1])
                {
                    phones.Add(cmd[1]);
                    phones.RemoveAt(i);
                }
            }
        }
    }
}