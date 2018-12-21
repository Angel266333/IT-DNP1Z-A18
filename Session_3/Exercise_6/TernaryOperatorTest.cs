using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter current score: ");
            int score = Console.Read();
            string message = "";
            message = (score > 1337) ? "This is a new highscore!" : "You need more points to beat the highscore!";
            Console.WriteLine(message);
        }
    }
}
