using System;
using System.Collections.Generic;

namespace Exercise_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stackIntegers = new Stack<int>();

            Stack<String> stackStrings = new Stack<String>();

            Program.TakeStack(stackIntegers, 10, 20, 30);
            Program.TakeStack(stackStrings, "Test", "Test2", "Test3");
            foreach (var number in stackIntegers)
            {
                Console.WriteLine(number.ToString());
            }

            foreach (var String in stackStrings)
            {
                Console.WriteLine(String);
            }

        }

        public static void TakeStack<T>(Stack<T> takenStack, params T[] values)
        {

            foreach (var value in values)
            {
                takenStack.Push(value);
            }
        }
    }
}