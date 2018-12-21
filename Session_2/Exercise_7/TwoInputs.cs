using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            String numberOneInput = Console.ReadLine();
            Console.WriteLine("Please enter second number: ");
            String numberTwoInput = Console.ReadLine();

            int numberOne = Convert.ToInt32(numberOneInput);
            int numberTwo = Convert.ToInt32(numberTwoInput);


            if (numberOne > numberTwo)
            {
                Console.WriteLine("Highest number is: " + numberOne);
            }
            else if (numberTwo > numberOne)
            {
                Console.WriteLine("Highest number is: " + numberTwo);
            }
            else if (numberOne == numberTwo)
            {
                Console.WriteLine("The numbers are equal! You entered: " + numberOne + " for both inputs!");
            }

        }
    }
}