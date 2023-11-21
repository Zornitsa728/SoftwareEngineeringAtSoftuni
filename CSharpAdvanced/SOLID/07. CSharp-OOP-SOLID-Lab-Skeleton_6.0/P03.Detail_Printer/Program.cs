using P03.Detail_Printer;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            List<IEmployee> employees = new List<IEmployee>();
            IEmployee ivan = new Employee("Ivan");
            employees.Add(ivan);
            IEmployee manager = new Manager("Pesho", new List<string> { "Document1" , "Document2"});
            employees.Add(manager);


            DetailsPrinter detail = new DetailsPrinter(employees);
            detail.PrintDetails();
        }
    }
}
