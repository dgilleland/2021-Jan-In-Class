using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World!";

            Console.WriteLine(greeting);
            Console.WriteLine(greeting.Length);
            Console.WriteLine(greeting.Quack());
        }
    }

    public static class MyExtensions
    {
        public static string Quack(this string self)
        {
            return $"{self} (quack)";
        }
    }
}
