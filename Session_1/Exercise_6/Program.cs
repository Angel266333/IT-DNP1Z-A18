using System;
using MathLib;

namespace Exercise_6
{
    class Program
    {

        static int numberOne;
        static int numberTwo;
        static int resultOne;
        static int[] arrayIntegersOne = new int[1];
        static int[] arrayIntegersTwo = new int[1];
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            numberOne = Convert.ToInt32(Console.ReadLine());
            numberTwo = Convert.ToInt32(Console.ReadLine());
            resultOne = Calculator.Add(numberOne, numberTwo);
            Calculator.Add(numberOne, numberTwo);
            Console.WriteLine("The output of the first method is: " + Convert.ToString(Calculator.Add(numberOne, numberTwo)));
            arrayIntegersOne[0] = numberOne;
            arrayIntegersTwo[0] = numberTwo;
            Add(arrayIntegersOne, arrayIntegersTwo);
            if (resultOne == Add(arrayIntegersOne, arrayIntegersTwo)) {
                Console.WriteLine("Method overloading was successful!\nComparison was done between: " + Convert.ToString(resultOne) + " and "
                 + Convert.ToString(Add(arrayIntegersOne, arrayIntegersTwo)));
            }
            else {
                Console.WriteLine("There is a problem with the code or equal value sides changed!");
            }
        }

        public static int Add(int[] arrayIntegersOne, int[] arrayIntegersTwo)
        {
            int alpha = arrayIntegersOne[0];
            int beta = arrayIntegersTwo[0];
            return alpha + beta;
        }
    }
}