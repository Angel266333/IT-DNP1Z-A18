using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a chunk of text:");
            String enteredText = Console.ReadLine();
            Console.WriteLine(StringUtility.SummarizeText(enteredText));
        }
    }
}
