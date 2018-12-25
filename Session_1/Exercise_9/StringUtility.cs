using System;

namespace Exercise_9
{
    static class StringUtility
    {
        
        static String[] cutString;
        public static String[] SummarizeText(String text) {

            if(text.Length >= 20) {
                cutString = text.Split("...", 20);
                return cutString;
                // TODO: No idea how to make it print out.
            } else if (text.Length < 20) {
                Console.WriteLine("Please enter 20 or more characters! Error.");
        }
            return cutString;
        }
    }
}
