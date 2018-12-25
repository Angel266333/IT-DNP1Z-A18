using System;

namespace Exercise_3
{
    class LoopProgram
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 101; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Even number: " + i);
                }
                for (int y = 0; y < 101; y++)
                {

                    while (!(y % 2 == 0))
                    {
                        Console.WriteLine("Odd number: " + y);
                        y++;
                    }
                }
            }
        }
    }
}