using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            DNPStudent DNPStudent = new DNPStudent();

            student.SayHi();
            DNPStudent.SayHi();

            // upcasting child object
            // virtual override => child method used
            // hiding with new => parent method used
            student = DNPStudent;
            student.SayHi();
            DNPStudent.SayHi();
        }
    }
}