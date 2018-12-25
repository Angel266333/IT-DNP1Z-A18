using System;

namespace MathLib
{
    static class Calculator
    {
        public static int Plus(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        public static int Minus(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
        public static int Division(int numberOne, int numberTwo)
        {
            try {
            return numberOne / numberTwo;
            } catch (DivideByZeroException e) {
                Console.WriteLine("Cannot divide by zero!");
            }
            return 0;
        }
        public static int Multiplication(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
    }
}