using System;

namespace Exercise_8
{
    public class DelegatorAligator
    {
        public delegate void Notifier(String arg0);
        public static void SayHello(String name) {
            Console.WriteLine($"Hello, {name}");
    }
        public static void SayGoodbye(String name) {
            Console.WriteLine($"Goodbye, {name}");
        }

        static void Main(string[] args)
        {
            Notifier notifier = SayHello;
            notifier += SayGoodbye;

            notifier("ANG3L");
        }
    }
}
