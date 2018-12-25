using System;
using MathLib;

namespace Exercise_10
{
    class Program
    {
        static int nonOverloadedValue = -1;
        static int operationNumber;
        static string operatorSign;
        static string operatorPLUS = "+";
        static string operatorMINUS = "-";
        static string operatorDIV = "/";
        static string operatorMULTI = "*";
        static int numberOne;
        static int numberTwo;
        static int[] arrayIntegersOne = new int[1];
        static int[] arrayIntegersTwo = new int[1];
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter two numbers:");
                try {
                numberOne = Convert.ToInt32(Console.ReadLine());
                numberTwo = Convert.ToInt32(Console.ReadLine());
                } catch (OverflowException e) {
                    Console.WriteLine("Value is too big!");
                    return;
                }
                Console.WriteLine("Numbers entered are: " + numberOne + "," + numberTwo);
                Console.WriteLine("Please enter one of the following operation signs:\nPLUS(+), MINUS(-), DIVISION(/), MULTIPLICATION(*)");
                operatorSign = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid input!");
                return;
            }
            operationDecider(operatorSign);
            Console.WriteLine("The output of the first method is: " + Convert.ToString(nonOverloadedValue));
            arrayIntegersOne[0] = numberOne;
            arrayIntegersTwo[0] = numberTwo;
            Console.WriteLine("DEBUG NON-OVERLOADED VALUE: " + nonOverloadedValue);
            switch (operationNumber)
            {
                case 1:
                    {
                        if (nonOverloadedValue == Plus(arrayIntegersOne, arrayIntegersTwo))
                        {
                            Console.WriteLine("Method overloading was successful!\nComparison was done between: " + Convert.ToString(nonOverloadedValue) + " and "
                             + Convert.ToString(Plus(arrayIntegersOne, arrayIntegersTwo)));
                        }
                        break;
                    }
                case 2:
                    {
                        if (nonOverloadedValue == Minus(arrayIntegersOne, arrayIntegersTwo))
                        {
                            Console.WriteLine("Method overloading was successful!\nComparison was done between: " + Convert.ToString(nonOverloadedValue) + " and "
                             + Convert.ToString(Minus(arrayIntegersOne, arrayIntegersTwo)));
                        }
                        break;
                    }
                case 3:
                    {
                        if (nonOverloadedValue == Divison(arrayIntegersOne, arrayIntegersTwo))
                        {
                            Console.WriteLine("Method overloading was successful!\nComparison was done between: " + Convert.ToString(nonOverloadedValue) + " and "
                             + Convert.ToString(Divison(arrayIntegersOne, arrayIntegersTwo)));
                        }
                        break;
                    }
                case 4:
                    {
                        if (nonOverloadedValue == Multiplication(arrayIntegersOne, arrayIntegersTwo))
                        {
                            Console.WriteLine("Method overloading was successful!\nComparison was done between: " + Convert.ToString(nonOverloadedValue) + " and "
                             + Convert.ToString(Multiplication(arrayIntegersOne, arrayIntegersTwo)));
                        }
                    }
                    break;
            }
        }
        public static int operationDecider(String operatorSign)
        {

            //+++\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            if (operatorSign.Contains(operatorPLUS) &&
            !operatorSign.Contains(operatorMINUS) &&
            !operatorSign.Contains(operatorDIV) &&
            !operatorSign.Contains(operatorMULTI))
            {
                operationNumber = 1;
                nonOverloadedValue = Calculator.Plus(numberOne, numberTwo);
                Console.WriteLine("Operation number is: " + operationNumber);
                return Plus(arrayIntegersOne, arrayIntegersTwo);
                //+++\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            }   //                                             \\
                //---\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            else if (operatorSign.Contains(operatorMINUS) &&
          !operatorSign.Contains(operatorPLUS) &&
          !operatorSign.Contains(operatorDIV) &&
          !operatorSign.Contains(operatorMULTI))
            {
                operationNumber = 2;
                nonOverloadedValue = Calculator.Minus(numberOne, numberTwo);
                Console.WriteLine("Operation number is: " + operationNumber);
                return Minus(arrayIntegersOne, arrayIntegersTwo);
                //---\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            }   //                                             \\
                //-/-\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            else if (operatorSign.Contains(operatorDIV) &&
              !operatorSign.Contains(operatorMINUS) &&
              !operatorSign.Contains(operatorPLUS) &&
              !operatorSign.Contains(operatorMULTI))
            {
                operationNumber = 3;
                nonOverloadedValue = Calculator.Division(numberOne, numberTwo);
                Console.WriteLine("Operation number is: " + operationNumber);
                try {
                return numberOne / numberTwo;
                } catch (DivideByZeroException e) {
                    return 0;
                }
                // return Divison(arrayIntegersOne, arrayIntegersTwo); 
            }   //-/-////////////////////////////////////////////
                //                                             \\
                //***\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            else if (operatorSign.Contains(operatorMULTI) &&
              !operatorSign.Contains(operatorMINUS) &&
              !operatorSign.Contains(operatorPLUS) &&
              !operatorSign.Contains(operatorDIV))
            {
                operationNumber = 4;
                nonOverloadedValue = Calculator.Multiplication(numberOne, numberTwo);
                Console.WriteLine("Operation number is: " + operationNumber);
                return Multiplication(arrayIntegersOne, arrayIntegersTwo);
                //***////////////////////////////////////////////
            }
            return -1;
        }
        public static int Plus(int[] arrayIntegersOne, int[] arrayIntegersTwo)
        {
            int alpha = arrayIntegersOne[0];
            int beta = arrayIntegersTwo[0];
            return alpha + beta;
        }

        public static int Minus(int[] arrayIntegersOne, int[] arrayIntegersTwo)
        {
            int gamma = arrayIntegersOne[0];
            int delta = arrayIntegersTwo[0];
            return gamma - delta;
        }

        public static int Divison(int[] arrayIntegersOne, int[] arrayIntegersTwo)
        {
            int epsilon = arrayIntegersOne[0];
            int zeta = arrayIntegersTwo[0];
            try {
            return epsilon / zeta;
            } catch (DivideByZeroException e) {
                Console.WriteLine("Division attempt unsucessful!");
                return 0;
            }
        }

        public static int Multiplication(int[] arrayIntegersOne, int[] arrayIntegersTwo)
        {
            int eta = arrayIntegersOne[0];
            int theta = arrayIntegersTwo[0];
            return eta * theta;
        }
    }
}