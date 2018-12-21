using System;

namespace Exercise_3
{
    public static class List
    {
        private static Random rnd = new Random();
        public static T Randomize<T>(this List<T> list) {

            int r = rnd.Next(list.Count);
            return list[r];
        }

        public static void Shuffle<T>(this List<T> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rnd.Next(n+1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public void Add(int number) {
            throw new NotImplementedException();
        }

        public int this[int index] 
        {
            get { throw new NotImplementedException(); 
            }
        }

        // TODO

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
