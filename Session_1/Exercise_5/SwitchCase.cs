using System;

namespace Exercise_5
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            while(true) {
                try {
                Console.WriteLine("Please enter a number between 0 and 10: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number < 0 || number > 10)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number!");
                }
            
                 else if (number >= 0 || number <= 10)
                {
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("This is the first number");
                            break;
                        case 10:
                            Console.WriteLine("This is the last number");
                            break;
                    }
                Console.WriteLine(number);
                }
                } catch (FormatException e) {
                    Console.WriteLine("Invalid input!");
                }
        }
    }
}
}