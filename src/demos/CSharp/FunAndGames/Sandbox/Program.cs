using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of my Program class that will
            // act as the "driver" for my game.
            DieGameDriver app = new DieGameDriver();
            app.Start();
        }
    }
}
