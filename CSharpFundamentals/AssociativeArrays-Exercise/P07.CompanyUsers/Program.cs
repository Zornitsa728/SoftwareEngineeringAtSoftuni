namespace P07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();
            ValidateCompaniesAndEmployees(employees);

            PrintResult(employees);
        }
        static void PrintResult(Dictionary<string, List<string>> employees)
        {
            foreach (var kvp in employees)
            {
                Console.WriteLine(kvp.Key);
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }
            }
        }
        private static void ValidateCompaniesAndEmployees(Dictionary<string, List<string>> employees)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" -> ");
                string companyName = cmdArgs[0];
                string employerId = cmdArgs[1];

                if (IsCompanyExist(employees, companyName) && !IsEmployeeExist(employees, employerId))
                {
                    employees[companyName].Add(employerId);
                }
                else if (!IsCompanyExist(employees, companyName))
                {
                    employees.Add(companyName, new List<string>());
                    employees[companyName].Add(employerId);
                }
            }
        }
        static bool IsEmployeeExist(Dictionary<string, List<string>> employees, string employerId)
        {
            if (employees.Any(x => x.Value.Contains(employerId)))
            {
                return true;
            }

            return false;
        }
        static bool IsCompanyExist(Dictionary<string, List<string>> employees, string companyName)
        {
            if (employees.ContainsKey(companyName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}