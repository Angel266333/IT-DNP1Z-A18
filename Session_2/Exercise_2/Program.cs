using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.EmployNewEmployee(new FullTimeEmployee("Angel", 2500.22));
            company.EmployNewEmployee(new FullTimeEmployee("Maya", 6226.28));

            company.EmployNewEmployee(new PartTimeEmployee("Mario", 1500, 16));
            company.EmployNewEmployee(new PartTimeEmployee("Luidgi", 2000, 18));

            Console.WriteLine("Total monthly salary: " + company.GetMonthlySalaryTotal());
        }
    }
}
