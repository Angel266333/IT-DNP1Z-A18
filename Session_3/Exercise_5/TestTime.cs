using System;

namespace Exercise_5
{
    class TestTime
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(16, 20);
            Time t2 = new Time(3, 25);
            Time t3 = t1 + t2;
            Console.WriteLine(t3.ToString());
        }
    }
}
