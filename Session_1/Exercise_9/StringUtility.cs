using System;

namespace Exercise_9
{
    static class StringUtility
    {
    static String cutString;
        
        public static String SummarizeText(String text) {
            if(text.Length >= 20) {
                cutString = Convert.ToString(text.Split("...",20));
            } else if (text.Length < 20) {
                Console.WriteLine("Please enter 20 or more characters! Error.");
        }
            return cutString;
        }
    }
}
