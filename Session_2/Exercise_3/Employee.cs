using System;

namespace Exercise_3
{
    public abstract class Employee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public abstract double GetMonthlySalary();
    }
}
