using System;

namespace taskTwoDelegates
{
    public delegate void Message();

    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            Pong pong = new Pong();

            ping.HitTheBall += pong.Hit;
            pong.HitTheBall += ping.Hit;

            ping.Hit();

        }
    }
}
