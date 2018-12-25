using System;
using System.Collections.Generic;

namespace Exercise_3
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();
        public void EmployNewEmployee(Employee e)
        {
            employees.Add(e);
        }

    public double GetMonthlySalaryTotal()
    {
        double total = 0.0;
        foreach(Employee e in employees)
        {
            total += e.GetMonthlySalary();
        }
        return total;
        }
    }
}