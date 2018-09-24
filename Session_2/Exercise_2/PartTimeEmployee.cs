using System;

namespace Exercise_2
{
    public class PartTimeEmployee : Employee
    {
        private double _hourlyWage;
        private int _hoursPerMonth;

        public PartTimeEmployee(string name, int hoursPerMonth, double hourlyWage) : base(name) {
            _hourlyWage = hourlyWage;
            _hoursPerMonth = hoursPerMonth;
        }
        public override double GetMonthSalary() {
            return _hourlyWage * _hoursPerMonth;
        }
    }
}
