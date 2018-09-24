using System;

namespace Exercise_8
{
    class Gun
    {
        private static int gunCount = 0;
        private static int bulletCount = 0;
        private int shotsFired = 0;

        public Gun() {
            gunCount++;
        }

        public void Shoot() {
            bulletCount++;
            shotsFired++;
            Console.WriteLine(GunToString());
        }
        public String GunToString() {
            return $"BANG! Gun Count: {gunCount} Bullet Count: {bulletCount} Shots Fired: {shotsFired}";
        }
    }
}
