using System.Security.Principal;

namespace MoneyTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankInfo = Console.ReadLine()
                .Split(",");

            Dictionary<int, decimal> bankAcounts = new Dictionary<int, decimal>();

            foreach (string currUser in bankInfo)
            {
                string[] tokens = currUser.Split("-");
                int accNum = int.Parse(tokens[0]);
                decimal accBalance = decimal.Parse(tokens[1]);

                bankAcounts.Add(accNum, accBalance);
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input
                    .Split(" ");

                try
                {
                    string cmd = IsCmdValid(cmdArgs[0]);

                    int account = IsAccountValid(cmdArgs[1], bankAcounts);

                    if (cmd == "Deposit")
                    {
                        bankAcounts[account] += decimal.Parse(cmdArgs[2]);
                    }
                    else
                    {
                        decimal currBalance = bankAcounts[account];

                        decimal newBalance = IsBalanceValid(cmdArgs[2], currBalance);

                        bankAcounts[account] -= newBalance;
                    }

                    Console.WriteLine($"Account {account} has new balance: {bankAcounts[account]:f2}");

                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.ParamName);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        static string IsCmdValid(string cmd)
        {
            if (cmd != "Deposit" && cmd != "Withdraw")
            {
                throw new ArgumentException("Invalid command!");
            }

            return cmd;
        }

        static int IsAccountValid(string account, Dictionary<int, decimal> bankAccounts)
        {
            if (!int.TryParse(account, out int result))
            {
                throw new ArgumentException("Invalid command!");
            }

            if (!bankAccounts.ContainsKey(result))
            {
                throw new ArgumentException("Invalid account!");
            }

            return result;
        }

        static decimal IsBalanceValid(string balance, decimal currBalance)
        {
            if (!decimal.TryParse(balance, out decimal result))
            {
                throw new ArgumentException("Invalid command!");
            }

            if (result > currBalance)
            {
                throw new ArgumentOutOfRangeException("Insufficient balance!");
            }

            return result;
        }
    }
}