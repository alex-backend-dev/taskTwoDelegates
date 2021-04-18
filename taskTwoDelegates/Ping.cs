using System;
using System.Threading;

namespace taskTwoDelegates
{
    public class Ping
    {
        public event Message HitTheBall;

        public void Hit()
        {
            Console.WriteLine("Ping recieved Pong");
            Thread.Sleep(800);
            HitTheBall();
        }
    }
}
