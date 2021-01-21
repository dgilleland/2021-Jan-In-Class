using System;


namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of my Program class that will
            // act as the "driver" for my game.
            //DieGameDriver app = new DieGameDriver();
            GoFishGameDriver app = new GoFishGameDriver();
            app.Start();
        }
    }
}
