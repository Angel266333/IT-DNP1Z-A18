using System;

namespace Exercise_2
{
    class Bomb : IExplodable<double>
    {

        public void Explode(double radius) {
            Console.WriteLine("Boom! The explosion size was " + radius);
        }

        static void Main(string[] args)
        {
            Bomb bomb = new Bomb();
            bomb.Explode(3.14);
        }
    }
}
