using System;

namespace Exercise_7
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers to sum up: ");
            //TODO - Fix
            int userInput1 = Console.Read();
            int userInput2 = Console.Read();
            Console.WriteLine("The sum of the two values is: " + Add(userInput1, userInput2));
        }
        public static int Add(params int[] args)
        {
            int sum = args[0] + args[1];
            return sum;
        }
    }
}