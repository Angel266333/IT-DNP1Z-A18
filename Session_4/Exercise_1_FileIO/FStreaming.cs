using System;

namespace Exercise_1
{

    class FStreaming
    {
        static string FOutput;

        static void Main(string[] args)
        {
        FOutput = System.IO.File.ReadAllText("fileText.txt");
        Console.WriteLine("Words counted: " + getWordCount());
        }
        private static int getWordCount() {
        int count = FOutput.Split(' ').Length;
        return count;
    }
}
}
