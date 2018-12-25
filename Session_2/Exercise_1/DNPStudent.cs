using System;

namespace Exercise_1
{
    public class DNPStudent : Student
    {
        public override void SayHi() {
            Console.WriteLine("Hi! I am a DNP student!");
            base.SayHi();
        }
}
}
