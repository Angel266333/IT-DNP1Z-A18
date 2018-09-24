using System;

namespace Exercise_8
{
    class Program
    {
        static string[] userName = new string[1];

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("The reversed string is:\n" + Reverse(input));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
