using System;

namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•Брой отворени табове в браузъра n - цяло число в интервала [1...10]
            int openTabs = int.Parse(Console.ReadLine());
            //•Заплата - число в интервала[500...1500]
            int salary = int.Parse(Console.ReadLine());

            for (int i=1; i<=openTabs; i++)
            {
                string website = Console.ReadLine(); //•След това n – на брой пъти се чете име на уебсайт – текст
                if ( website == "Facebook")
                {
                    salary -= 150;
                }
                else if (website == "Instagram")
                {
                    salary -= 100;
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                
            }
            if(salary > 0 )
            {
                Console.WriteLine(salary);
            }

        }
    }
}
