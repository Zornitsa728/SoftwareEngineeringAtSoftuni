using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] urls = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Smarthpone smarthpone = new Smarthpone();
            StationaryPhone stationaryPhone = new StationaryPhone();


            foreach (string phoneNumber in phoneNumbers)
            {
                try
                {
                    if (phoneNumber.Length == 10)
                    {
                        Console.WriteLine(smarthpone.Call(phoneNumber));
                    }
                    else
                    {
                        Console.WriteLine(stationaryPhone.Call(phoneNumber));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (string url in urls)
            {
                try
                {
                    Console.WriteLine(smarthpone.Browse(url));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}