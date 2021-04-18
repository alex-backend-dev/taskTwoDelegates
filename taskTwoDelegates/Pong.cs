using System;
using System.Threading;

namespace taskTwoDelegates
{
    public class Pong
    {
        public event Message HitTheBall;

        public void Hit()
        {
            Console.WriteLine("Pong recieved Ping");
            Thread.Sleep(800);
            HitTheBall();
        }
    }
}
