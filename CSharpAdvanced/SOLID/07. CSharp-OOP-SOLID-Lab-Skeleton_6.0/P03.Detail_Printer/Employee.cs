using P03.Detail_Printer;
using System;

namespace P03.DetailPrinter
{
    public class Employee : IEmployee, IPrinter
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(Name);
        }
    }
}
