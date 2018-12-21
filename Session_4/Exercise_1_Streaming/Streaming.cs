using System;
using System.IO;

namespace Exercise_1
{
    class Streaming
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Words:" + GetWordsCount());
            Console.WriteLine("Longest: " + getTheLongestWord());
        }

        public static int GetWordsCount()
        {
            try
            {
                using (StreamReader sr = new StreamReader("textFile.txt"))
                {
                    String line = sr.ReadToEnd();
                    var words = line.Split(" ");
                    return words.Length;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public static String getTheLongestWord() {
            try {
            using (StreamReader sr = new StreamReader("textFile.txt"))
            {
                String line = sr.ReadToEnd();
                var words = line.Split(" ");
                int maxLen = 0;
                var longestWord = "";

                foreach (var word in words) {
                    if (word.Length > maxLen) {
                        longestWord = word;
                        maxLen = word.Length;
                    }
                }
                return longestWord;
            }
            }
            catch (Exception e) {
                return "";
            }
        }
    }
}