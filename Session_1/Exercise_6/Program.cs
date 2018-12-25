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
            if (resultOne == Add(arrayIntegersOne, arrayIntegersTwo)) {
                Console.WriteLine("Method overloading was successful!\nComparison was done between: " + Convert.ToString(resultOne) + " and "
                 + Convert.ToString(Add(arrayIntegersOne, arrayIntegersTwo)));
                Console.WriteLine("String method returned: " + 
                Convert.ToString(Add(Convert.ToString(numberOne), Convert.ToString(numberTwo))));
            }
            else {
                Console.WriteLine("There is a problem with the code or equal value sides changed!");
            }
        }

        // Overload with Array
        public static int Add(int[] arrayIntegersOne, int[] arrayIntegersTwo)
        {
            int alpha = arrayIntegersOne[0];
            int beta = arrayIntegersTwo[0];
            return alpha + beta;
        }

        // Overload with String
        public static double Add(String numberOne, String numberTwo) {
            double alpha = Convert.ToDouble(numberOne);
            double beta = Convert.ToDouble(numberTwo);
            return alpha + beta;
        }
    }
}