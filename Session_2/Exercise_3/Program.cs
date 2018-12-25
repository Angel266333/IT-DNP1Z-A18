using System;

namespace Exercise_3
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

            company.EmployNewEmployee(new PartTimeStudent("Andrea", 2400, 24, 2018));
            company.EmployNewEmployee(new PartTimeStudent("Ioan", 2200, 23, 2016));

            Console.WriteLine("Total monthly salary: " + company.GetMonthlySalaryTotal());
        }
    }
}
