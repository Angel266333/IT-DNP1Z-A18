using System;

namespace Exercise_4
{
    public class Player
    {      
        public void Shout(String arg0) {
            Console.WriteLine(arg0);
        }

        public void Shout(int arg0) {
            Console.WriteLine($"{arg0} is my lucky number!");
        }

        public void Shout(Enemy enemy) {
            Console.WriteLine($"The enemy can do {enemy._damage} damage to me.");
        }
    }
}