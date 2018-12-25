using System;

namespace Exercise_3
{
    public class PartTimeStudent : PartTimeEmployee, IStudent
    {
        private int startYearOfEducation;
        public PartTimeStudent(string name, double hourlyWage, int hoursPerMonth, int startYearOfEducation = 2000)
            : base(name, hourlyWage, hoursPerMonth)
        {
            this.startYearOfEducation = startYearOfEducation;
        }

        public void Register(int year) {
        startYearOfEducation = year;
        }
    }
}