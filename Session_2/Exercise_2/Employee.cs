using System;

namespace Exercise_2
{
   public abstract class Employee
    {
        private String _name;

        public Employee(String name) {
            _name = name;
        }
    public abstract double getMonthSalary() { 
    }
    }
}
