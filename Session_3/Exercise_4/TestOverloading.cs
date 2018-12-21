using System;

namespace Exercise_4
{
    class TestOverloading
    {
        static void Main(string[] args)
        {
            Player player0 = new Player();
            player0.Shout("A wild enemy appeard!");
            player0.Shout(44);
            player0.Shout(new Enemy(44));
        }
    }
}